using Microsoft.AspNetCore.Mvc;
using MoHinh.Models;
namespace MoHinh.ViewComponents
{
    public class CartSummary : ViewComponent
    {
        private MyCart cart;
        public CartSummary(MyCart cartService)
        {
            cart = cartService;
        }
        public IViewComponentResult Invoke()
        {
            return View(cart);
        }
    }
}

