using System.Collections.Generic;
namespace MoHinh.Models.ViewModels
{
    public class HinhsListViewModel
    {
        public IEnumerable<Hinh> Hinhs { get; set; }
        public PagingInfo PagingInfo { get; set; }
        public string CurrentGenre { get; set; }
    }
}

