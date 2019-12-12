using ApplicationCore.Entities;
using Infrastructure.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorSample.Services.Service;
using RazorSample.Services.IService;
using RazorSample.ViewModels;
namespace RazorSample.Pages.Admin.QLPhuongTien
{
    public class IndexModel : PageModel
    {
        private readonly IPhuongTienService _PhuongTienService;
        public IndexModel(IPhuongTienService PhuongTienService)
        {
            _PhuongTienService = PhuongTienService;
        }
        [BindProperty(SupportsGet = true)]
        public PhuongTien PhuongTien { get; set; }

        public PhuongTienVM PhuongTienVM { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        [BindProperty(SupportsGet = true)]
        public string Genre { get; set; }
        public void OnGet(string searchString, string genre, int pageIndex = 1)
        {
            searchString = SearchString;
            genre = Genre;
            PhuongTienVM = _PhuongTienService.GetPhuongTienViewModel(searchString, genre, pageIndex);
        }
    }
}