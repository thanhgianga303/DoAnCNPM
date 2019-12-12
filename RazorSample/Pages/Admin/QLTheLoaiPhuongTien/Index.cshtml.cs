using ApplicationCore.Entities;
using Infrastructure.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorSample.Services.Service;
using RazorSample.Services.IService;
using RazorSample.ViewModels;
namespace RazorSample.Pages.Admin.QLTheLoaiPhuongTien
{
    public class IndexModel : PageModel
    {
        private readonly ITheLoaiPhuongTienService _TheLoaiPhuongTienService;
        public IndexModel(ITheLoaiPhuongTienService TheLoaiPhuongTienService)
        {
            _TheLoaiPhuongTienService = TheLoaiPhuongTienService;
        }
        [BindProperty(SupportsGet = true)]
        public TheLoaiPhuongTien TheLoaiPhuongTien { get; set; }

        public TheLoaiPhuongTienVM TheLoaiPhuongTienVM { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        [BindProperty(SupportsGet = true)]
        public string Genre { get; set; }
        public void OnGet(string searchString, string genre, int pageIndex = 1)
        {
            searchString = SearchString;
            genre = Genre;
            TheLoaiPhuongTienVM = _TheLoaiPhuongTienService.GetTheLoaiPhuongTienViewModel(searchString, genre, pageIndex);
        }
    }
}