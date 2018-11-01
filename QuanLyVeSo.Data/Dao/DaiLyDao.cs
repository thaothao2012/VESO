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
            try
            {
                db.DaiLy.Add(entity);
                db.SaveChanges();
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        public bool Update(DaiLy entity)
        {
            try
            {
                var model = GetSingle(entity.MaDaiLy);

                model.SoDienThoai = entity.SoDienThoai;
                model.TenDaiLy = entity.TenDaiLy;
                model.TrangThai = entity.TrangThai;
                model.DiaChi = entity.DiaChi;
                model.Email = entity.Email;

                db.SaveChanges();
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }
        public bool Delete(string maDaiLy)
        {
            try
            {
                var entity = GetSingle(maDaiLy);
                db.DaiLy.Remove(entity);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
        public IEnumerable<DaiLy> ListPaged(int pageNumber, string query, int pageSize = 10)
        {
            var model = from c in db.DaiLy select c;

            if (!string.IsNullOrEmpty(query))
            {
                model = model.Where(p => p.TenDaiLy.ToLower().Contains(query.ToLower())
                                        || p.MaDaiLy.ToLower().Contains(query.ToLower()));
            }

            return model.OrderBy(p => p.MaDaiLy).ToPagedList(pageNumber, pageSize);
        }

        public DaiLy GetSingle(string id)
        {
            return db.DaiLy.FirstOrDefault(p => p.MaDaiLy == id);
        }

        public IEnumerable<DaiLy> AllDaiLys()
        {
            return db.DaiLy;
        }

        public bool ChangeStatus(string maDaiLy)
        {
            var entity = db.DaiLy.FirstOrDefault(p => p.MaDaiLy == maDaiLy);
            entity.TrangThai = !entity.TrangThai;
            db.SaveChanges();

            return entity.TrangThai;
        }

        
        #endregion Methods
    }
}