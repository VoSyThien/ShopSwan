using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MoHinh.MyTagHelper;
using MoHinh.Models;
using System.Linq;
namespace MoHinh.Pages
{
    public class MyCartModel : PageModel
    {
        private IMoHinhRepository repository;
        public MyCartModel(IMoHinhRepository repo, MyCart myCartService)
        {
            repository = repo;
            myCart = myCartService;
        }
        public MyCart myCart { get; set; }
        public string ReturnUrl { get; set; }
        public void OnGet(string returnUrl)
        {
            ReturnUrl = returnUrl ?? "/";
        }
        public IActionResult OnPost(long hinhId, string returnUrl)
        {
            Hinh hinh = repository.Hinhs
            .FirstOrDefault(b => b.HinhID == hinhId);
            myCart.AddItem(hinh, 1);
            return RedirectToPage(new { returnUrl = returnUrl });
        }
        public IActionResult OnPostRemove(long hinhId, string returnUrl)
        {
            myCart.RemoveLine(myCart.Lines.First(cl =>
            cl.Hinh.HinhID == hinhId).Hinh);
            return RedirectToPage(new { returnUrl = returnUrl });
        }
    }
}
