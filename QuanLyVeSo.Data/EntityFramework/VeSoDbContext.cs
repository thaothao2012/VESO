using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace QuanLyVeSo.Data.EntityFramework
{
    public class VeSoDbContext : DbContext
    {
        public VeSoDbContext() : base("name=VeSoDbContext")
        {
        }

        public DbSet<PhatHanh> PhatHanh { get; set; }

        public DbSet<LoaiVeSo> LoaiVeSo { get; set; }

        public DbSet<DaiLy> DaiLy { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}