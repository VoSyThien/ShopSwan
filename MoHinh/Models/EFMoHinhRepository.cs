using System.Linq;
namespace MoHinh.Models
{
    public class EFMoHinhRepository : IMoHinhRepository
    {
        private MoHinhDbContext context;
        public EFMoHinhRepository(MoHinhDbContext ctx)
        {
            context = ctx;
        }
        public IQueryable<Hinh> Hinhs => context.Hinhs;
        public void CreateHinh(Hinh b)
        {
            context.Add(b);
            context.SaveChanges();
        }
        public void DeleteHinh(Hinh b)
        {
            context.Remove(b);
            context.SaveChanges();
        }
        public void SaveHinh(Hinh b)
        {
            context.SaveChanges();
        }
    }
}

