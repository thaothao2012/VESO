using PagedList;
using QuanLyVeSo.Data.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
namespace QuanLyVeSo.Data.Dao
{
    public class GiaiThuongDao
    {
        #region Singleton

        private static GiaiThuongDao instance;
        private readonly VeSoDbContext db = null;

        private GiaiThuongDao()
        {
            db = new VeSoDbContext();
        }

        public static GiaiThuongDao Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new GiaiThuongDao();
                }
                return instance;
            }
        }

        #endregion Singleton
        #region Methods

        public bool Create(GiaiThuong entity)
        {
            try
            {
                db.GiaiThuong.Add(entity);
                db.SaveChanges();
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        public IEnumerable<GiaiThuong> ListPaged(int pageNumber, string query, int pageSize = 10)
        {
            var model = from c in db.GiaiThuong select c;
            if (!string.IsNullOrEmpty(query))
            {
                model = model.Where(p => p.TenGiai.ToLower().Contains(query.ToLower())
                                        || p.MaGiaiThuong.ToLower().Contains(query.ToLower()));
            }

            return model.OrderBy(p => p.MaGiaiThuong).ToPagedList(pageNumber, pageSize);
        }

        public GiaiThuong GetSingle(string id)
        {
            return db.GiaiThuong.FirstOrDefault(p => p.MaGiaiThuong == id);
        }

        public bool Update(GiaiThuong entity)
        {
            try
            {
                var model = GetSingle(entity.MaGiaiThuong);
                model.TenGiai = entity.TenGiai;
                model.TienThuong = entity.TienThuong;
                db.SaveChanges();
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }
        public bool Delete(string maGiaiThuong)
        {
            try
            {
                var entity = GetSingle(maGiaiThuong);
                db.GiaiThuong.Remove(entity);
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
