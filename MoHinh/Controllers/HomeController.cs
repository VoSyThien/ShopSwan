using Microsoft.AspNetCore.Mvc;
using MoHinh.Models;
using MoHinh.Models.ViewModels;
using System.Linq;

public class HomeController : Controller
{
    private IMoHinhRepository repository;
    public int PageSize = 3;
    public HomeController(IMoHinhRepository repo)
    {
        repository = repo;
    }
    public IActionResult Index(string genre, int hinhPage = 1)
 => View(new HinhsListViewModel
 {
     Hinhs = repository.Hinhs
 .Where(p => genre == null || p.TheLoai == genre)
 .OrderBy(p => p.HinhID)
 .Skip((hinhPage - 1) * PageSize)
 .Take(PageSize),
     PagingInfo = new PagingInfo
     {
         CurrentPage = hinhPage,
         ItemsPerPage = PageSize,
         TotalItems = genre == null ?
 repository.Hinhs.Count() :
 repository.Hinhs.Where(e =>
 e.TheLoai == genre).Count()
     },
     CurrentGenre = genre
 });
}