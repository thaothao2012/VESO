using PagedList;
using QuanLyVeSo.Data.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QuanLyVeSo.Data.Dao
{
    public class CongNoDao
    {
        #region Singleton

        private static CongNoDao instance;
        private readonly VeSoDbContext db = null;

        private CongNoDao()
        {
            db = new VeSoDbContext();
        }

        public static CongNoDao Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CongNoDao();
                }
                return instance;
            }
        }

        #endregion Singleton
        #region Methods

        public bool Create(CongNo entity)
        {
            try
            {
                db.CongNo.Add(entity);
                db.SaveChanges();
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        public IEnumerable<CongNo> ListPaged(int pageNumber, string query, int pageSize = 10)
        {
            var model = from c in db.CongNo select c;
            if (!string.IsNullOrEmpty(query))
            {
                model = model.Where(p => p.MaDaiLy.ToLower().Contains(query.ToLower()));
            }

            return model.OrderBy(p => p.MaCongNo).ToPagedList(pageNumber, pageSize);
        }

        public CongNo GetSingle(int id)
        {
            return db.CongNo.FirstOrDefault(p => p.MaCongNo == id);
        }

        public bool Update(CongNo entity)
        {
            try
            {
                var model = GetSingle(entity.MaCongNo);

                model.MaDaiLy = entity.MaDaiLy;
                model.SoTienBan = entity.SoTienBan;
                model.HoaHong = entity.HoaHong;
                model.NgayNo = entity.NgayNo;
                model.SoTienNo = entity.SoTienNo;

                db.SaveChanges();
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }
        public bool Delete(int maCongNo)
        {
            try
            {
                var entity = GetSingle(maCongNo);
                db.CongNo.Remove(entity);
                db.SaveChanges();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
        #endregion Methods

    }
}
