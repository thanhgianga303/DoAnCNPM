using ApplicationCore.Entities;
using Infrastructure.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorSample.Services.Service;
using RazorSample.Services.IService;
using RazorSample.ViewModels;
namespace RazorSample.Pages.Admin.QLNguoiDieuKhien
{
    public class IndexModel : PageModel
    {
        private readonly INguoiDieuKhienService _NguoiDieuKhienService;
        public IndexModel(INguoiDieuKhienService NguoiDieuKhienService)
        {
            _NguoiDieuKhienService = NguoiDieuKhienService;
        }
        [BindProperty(SupportsGet = true)]
        public NguoiDieuKhien NguoiDieuKhien { get; set; }

        public NguoiDieuKhienVM NguoiDieuKhienVM { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        [BindProperty(SupportsGet = true)]
        public string Genre { get; set; }
        public void OnGet(string searchString, string genre, int pageIndex = 1)
        {
            searchString = SearchString;
            genre = Genre;
            NguoiDieuKhienVM = _NguoiDieuKhienService.GetNguoiDieuKhienViewModel(searchString, genre, pageIndex);
        }
    }
}