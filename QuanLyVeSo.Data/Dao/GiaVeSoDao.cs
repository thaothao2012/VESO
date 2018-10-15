using PagedList;
using QuanLyVeSo.Data.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QuanLyVeSo.Data.Dao
{
    public class GiaVeSoDao
    {
        #region Singleton

        private static GiaVeSoDao instance;
        private readonly VeSoDbContext db = null;

        private GiaVeSoDao()
        {
            db = new VeSoDbContext();
        }

        public static GiaVeSoDao Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new GiaVeSoDao();
                }
                return instance;
            }
        }

        #endregion Singleton

        #region Methods

        public bool Create(GiaVeSo entity)
        {
            try
            {
                db.GiaVeSo.Add(entity);
                db.SaveChanges();
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        public bool Update(GiaVeSo entity)
        {
            try
            {
                var model = GetSingle(entity.MaGia);

                model.Gia = entity.Gia;
                model.NgayBatDau = entity.NgayBatDau;
                model.NgayKetThuc = entity.NgayKetThuc;
                model.TrangThai = entity.TrangThai;

                db.SaveChanges();
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        public IEnumerable<GiaVeSo> ListPaged(int pageNumber, string query, int pageSize = 2)
        {
            var model = from c in db.GiaVeSo select c;
            return model.OrderBy(p => p.MaGia).ToPagedList(pageNumber, pageSize);
        }

        public GiaVeSo GetSingle(int id)
        {
            return db.GiaVeSo.FirstOrDefault(p => p.MaGia == id);
        }

        public bool ChangeStatus(int maGia)
        {
            var entity = db.GiaVeSo.FirstOrDefault(p => p.MaGia == maGia);
            entity.TrangThai = !entity.TrangThai;
            db.SaveChanges();

            return entity.TrangThai;
        }

        public bool Delete(int maGia)
        {
            try
            {
                var entity = GetSingle(maGia);
                db.GiaVeSo.Remove(entity);
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
