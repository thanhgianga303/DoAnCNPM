using ApplicationCore.Entities;
using Infrastructure.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorSample.Services.Service;
using RazorSample.Services.IService;
using RazorSample.ViewModels;
namespace RazorSample.Pages.Admin.QLTaiKhoan
{
    public class IndexModel : PageModel
    {
        private readonly ITaiKhoanService _TaiKhoanService;
        public IndexModel(ITaiKhoanService TaiKhoanService)
        {
            _TaiKhoanService = TaiKhoanService;
        }
        [BindProperty(SupportsGet = true)]
        public TaiKhoan TaiKhoan { get; set; }

        public TaiKhoanVM TaiKhoanVM { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        [BindProperty(SupportsGet = true)]
        public string Genre { get; set; }
        public void OnGet(string searchString, string genre, int pageIndex = 1)
        {
            searchString = SearchString;
            genre = Genre;
            TaiKhoanVM = _TaiKhoanService.GetTaiKhoanViewModel(searchString, genre, pageIndex);
        }
    }
}