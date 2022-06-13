using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MoHinh.Models;
namespace MoHinh.ViewComponents
{
    public class GenreNavigation : ViewComponent
    {
        private IMoHinhRepository repository;
        public GenreNavigation(IMoHinhRepository repo)
        {
            repository = repo;
        }
        public IViewComponentResult Invoke()
        {
            return View(repository.Hinhs
            .Select(x => x.TheLoai)
            .Distinct()
            .OrderBy(x => x));
        }
    }
}


