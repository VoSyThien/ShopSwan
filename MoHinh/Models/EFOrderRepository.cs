using Microsoft.EntityFrameworkCore;
using System.Linq;
namespace MoHinh.Models
{
    public class EFOrderRepository : IOrderRepository
    {
        private MoHinhDbContext context;
        public EFOrderRepository(MoHinhDbContext ctx)
        {
            context = ctx;
        }
        public IQueryable<Order> Orders => context.Orders
        .Include(o => o.Lines)
        .ThenInclude(l => l.Hinh);
        public void SaveOrder(Order order)
        {
            context.AttachRange(order.Lines.Select(l => l.Hinh));
            if (order.OrderID == 0)
            {
                context.Orders.Add(order);
            }
            context.SaveChanges();
        }
    }
}
