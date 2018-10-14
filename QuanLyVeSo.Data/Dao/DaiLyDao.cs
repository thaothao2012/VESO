using PagedList;
using QuanLyVeSo.Data.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QuanLyVeSo.Data.Dao
{
    public class DaiLyDao
    {
        #region Singleton

        private static DaiLyDao instance;
        private readonly VeSoDbContext db = null;

        private DaiLyDao()
        {
            db = new VeSoDbContext();
        }

        public static DaiLyDao Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DaiLyDao();
                }
                return instance;
            }
        }

        #endregion Singleton

        #region Methods

        public bool Create(DaiLy entity)
        {
            var daiLy = db.DaiLy.Add(entity);
            db.SaveChanges();
            return daiLy != null;
        }

        public IEnumerable<DaiLy> ListPaged(int pageNumber, string query, int pageSize = 2)
        {
            var model = from c in db.DaiLy select c;
            if (!string.IsNullOrEmpty(query))
            {
                model = model.Where(p => p.TenDaiLy.ToLower().Contains(query.ToLower())
                                        || p.MaDaiLy.ToLower().Contains(query.ToLower()));
            }

            return model.OrderBy(p => p.MaDaiLy).ToPagedList(pageNumber, pageSize);
        }

        public bool ChangeStatus(string maDaiLy)
        {
            var entity = db.DaiLy.FirstOrDefault(p  => p.MaDaiLy == maDaiLy);
            entity.TrangThai = !entity.TrangThai;
            db.SaveChanges();

            return entity.TrangThai;
        }

        public IEnumerable<DaiLy> AllDaiLys()
        {
            return  db.DaiLy;
        }

        #endregion Methods
    }
}