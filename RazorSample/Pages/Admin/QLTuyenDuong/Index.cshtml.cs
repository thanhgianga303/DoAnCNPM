using ApplicationCore.Entities;
using Infrastructure.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorSample.Services.Service;
using RazorSample.Services.IService;
using RazorSample.ViewModels;
namespace RazorSample.Pages.Admin.QLTuyenDuong
{
    public class IndexModel : PageModel
    {
        private readonly ITuyenDuongService _TuyenDuongService;
        public IndexModel(ITuyenDuongService TuyenDuongService)
        {
            _TuyenDuongService = TuyenDuongService;
        }
        [BindProperty(SupportsGet = true)]
        public TuyenDuong TuyenDuong { get; set; }

        public TuyenDuongVM TuyenDuongVM { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        [BindProperty(SupportsGet = true)]
        public string Genre { get; set; }
        public void OnGet(string searchString, string genre, int pageIndex = 1)
        {
            searchString = SearchString;
            genre = Genre;
            TuyenDuongVM = _TuyenDuongService.GetTuyenDuongViewModel(searchString, genre, pageIndex);
        }
    }
}