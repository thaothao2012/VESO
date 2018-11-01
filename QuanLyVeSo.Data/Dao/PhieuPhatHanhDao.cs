using QuanLyVeSo.Data.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PagedList;
namespace QuanLyVeSo.Data.Dao
{
    public class PhieuPhatHanhDao
    {
        private static PhieuPhatHanhDao instance;
        private readonly VeSoDbContext db = null;
        private PhieuPhatHanhDao()
        {
            db = new VeSoDbContext();
        }
        public static PhieuPhatHanhDao Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new PhieuPhatHanhDao();
                }
                return instance;
            }
        }
        public bool Create(PhieuPhatHanh entity)
        {
            var phieuThu = db.PhieuPhatHanh.Add(entity);
            db.SaveChanges();
            return phieuThu != null;
        }
        public IEnumerable<PhieuPhatHanh> ListPaged(int pageNumber, string query, int pageSize = 2)
        {
            var model = from c in db.PhieuPhatHanh select c;
            if (!string.IsNullOrEmpty(query))
            {
                model = model.Where(p => p.MaPhieuPhatHanh.ToLower().Contains(query.ToLower()) 
                                         || p.MaDaiLy.ToLower().Contains(query.ToLower()));
            }
            return model.OrderBy(p => p.MaPhieuPhatHanh).ToPagedList(pageNumber, pageSize);
        }
        public bool Update(PhieuPhatHanh entity)
        {
            try
            {
                var model = GetSingle(entity.MaPhieuPhatHanh);
                model.MaDaiLy = entity.MaDaiLy;
                model.NgayPhatHanh = entity.NgayPhatHanh;
                model.TongSoLuongPhat = entity.TongSoLuongPhat;
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                return false;
            }

            return true;
        }
        public PhieuPhatHanh GetSingle(string id)
        {
            return db.PhieuPhatHanh.FirstOrDefault(m => m.MaPhieuPhatHanh == id);
        }
        public bool Delete(string id)
        {
            try
            {
                var model = GetSingle(id);
                db.PhieuPhatHanh.Remove(model);
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
