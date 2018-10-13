using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace QuanLyVeSo.Data.EntityFramework
{
    public class VeSoDbContext : DbContext
    {
        public VeSoDbContext() : base("name=VeSoDbContext")
        {
        }

        public DbSet<PhieuPhatHanh> PhieuPhatHanh { get; set; }

        public DbSet<LoaiVeSo> LoaiVeSo { get; set; }

        public DbSet<DaiLy> DaiLy { get; set; }

        public DbSet<PhieuDangKy> PhieuDangKy { get; set; }
        
        public DbSet<PhieuThu> PhieuThu { get; set; }

        public DbSet<GiaiThuong> GiaiThuong { get; set; }

        public DbSet<KetQuaXoSo> KetQuaXoSo { get; set; }

        public DbSet<CongNo> CongNo { get; set; }

        public DbSet<GiaVeSo> GiaVeSo { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

        }
    }
}