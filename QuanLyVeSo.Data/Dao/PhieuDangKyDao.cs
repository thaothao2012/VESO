using QuanLyVeSo.Data.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PagedList;

namespace QuanLyVeSo.Data.Dao
{
    public class PhieuDangKyDao
    {
        private static PhieuDangKyDao instance;
        private readonly VeSoDbContext db = null;
        private PhieuDangKyDao()
        {
            db = new VeSoDbContext();
        }
        public static PhieuDangKyDao Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new PhieuDangKyDao();
                }
                return instance;
            }
        }
        public bool Create(PhieuDangKy entity)
        {
            var phieuThu = db.PhieuDangKy.Add(entity);
            db.SaveChanges();
            return phieuThu != null;
        }
        public IEnumerable<PhieuDangKy> ListPaged(int pageNumber, string query, int pageSize = 2)
        {
            var model = from c in db.PhieuDangKy select c;
            if (!string.IsNullOrEmpty(query))
            {
                model = model.Where(p => p.MaPhieuDangKy.ToLower().Contains(query.ToLower())
                                         || p.MaDaiLy.ToLower().Contains(query.ToLower()));
            }
            return model.OrderBy(p => p.MaPhieuDangKy).ToPagedList(pageNumber, pageSize);
        }
        public bool Update(PhieuDangKy entity)
        {
            try
            {
                var model = GetSingle(entity.MaPhieuDangKy);
                model.MaDaiLy = entity.MaDaiLy;
                model.NgayDangKy = entity.NgayDangKy;
                model.TongSoLuongDangKy = entity.TongSoLuongDangKy;
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                return false;
            }

            return true;
        }
        public PhieuDangKy GetSingle(string id)
        {
            return db.PhieuDangKy.FirstOrDefault(m => m.MaPhieuDangKy == id);
        }
        public bool Delete(string id)
        {
            try
            {
                var model = GetSingle(id);
                db.PhieuDangKy.Remove(model);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;

        }
    }
    
}
