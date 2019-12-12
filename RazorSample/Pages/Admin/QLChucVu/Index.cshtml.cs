using ApplicationCore.Entities;
using Infrastructure.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorSample.Services.Service;
using RazorSample.Services.IService;
using RazorSample.ViewModels;
namespace RazorSample.Pages.Admin.QLChucVu
{
    public class IndexModel : PageModel
    {
        private readonly IChucVuService _ChucVuService;
        public IndexModel(IChucVuService ChucVuService)
        {
            _ChucVuService = ChucVuService;
        }
        [BindProperty(SupportsGet = true)]
        public ChucVu ChucVu { get; set; }

        public ChucVuVM ChucVuVM { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        [BindProperty(SupportsGet = true)]
        public string Genre { get; set; }
        public void OnGet(string searchString, string genre, int pageIndex = 1)
        {
            searchString = SearchString;
            genre = Genre;
            ChucVuVM = _ChucVuService.GetChucVuViewModel(searchString, genre, pageIndex);
        }
    }
}