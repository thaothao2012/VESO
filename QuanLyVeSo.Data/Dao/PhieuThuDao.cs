﻿using QuanLyVeSo.Data.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PagedList;


namespace QuanLyVeSo.Data.Dao
{
    public class PhieuThuDao
    {
        #region Singleton
        private static PhieuThuDao instance;
        private readonly VeSoDbContext db = null;

        private PhieuThuDao()
        {
            db = new VeSoDbContext();
        }
        public static PhieuThuDao Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new PhieuThuDao();
                }
                return instance;
            }
        }
        #endregion Singleton

        public bool Create(PhieuThu entity)
        {
            var phieuThu = db.PhieuThu.Add(entity);
            db.SaveChanges();
            return phieuThu != null;
        }
        public bool Edit(int id)
        {
            var entity = db.PhieuThu.SingleOrDefault(e => e.MaPhieuThu == id);
            return true;
        }
        public IEnumerable<PhieuThu> ListPaged(int pageNumber, string query, int pageSize = 2)
        {
            var model = from c in db.PhieuThu select c;
            if (!string.IsNullOrEmpty(query))
            {
                model = model.Where(p => p.MaDaiLy.ToLower().Contains(query.ToLower()));
            }
            return model.OrderBy(p => p.MaPhieuThu).ToPagedList(pageNumber, pageSize);
        }
       
    }
}
