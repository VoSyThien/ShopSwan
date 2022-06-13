using Microsoft.AspNetCore.Mvc;
using MoHinh.Models;
using System.Linq;
namespace MoHinh.Controllers
{
    public class OrderController : Controller
    {
        private IOrderRepository repository;
        private MyCart cart;
        public OrderController(IOrderRepository repoService, MyCart cartService)
        {
            repository = repoService;
            cart = cartService;
        }
        public ViewResult Checkout() => View(new Order());
        [HttpPost]
        public IActionResult Checkout(Order order)
        {
            if (cart.Lines.Count() == 0)
            {
                ModelState.AddModelError("", "Xin lỗi, giỏ hàng của bạn trống!");
            }
            if (ModelState.IsValid)
            {
                order.Lines = cart.Lines.ToArray();
                repository.SaveOrder(order);
                cart.Clear();
                return RedirectToPage("/Completed", new { orderId = order.OrderID });
            }
            else
            {
                return View();
            }
        }
    }
}


