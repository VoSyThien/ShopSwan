using Microsoft.EntityFrameworkCore;
namespace MoHinh.Models
{
    public class MoHinhDbContext : DbContext
    {
        public MoHinhDbContext(DbContextOptions<MoHinhDbContext> options)
        : base(options) { }
        public DbSet<Hinh> Hinhs { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
