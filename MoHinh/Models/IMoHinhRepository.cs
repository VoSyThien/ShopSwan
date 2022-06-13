using System.Linq;
namespace MoHinh.Models
{
    public interface IMoHinhRepository
    {
        IQueryable<Hinh> Hinhs { get; }
        void SaveHinh(Hinh b);
        void CreateHinh(Hinh b);
        void DeleteHinh(Hinh b);
    }
}


