using ApplicationCore.Entities;
using Infrastructure.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorSample.Services.Service;
using RazorSample.Services.IService;
using RazorSample.ViewModels;
namespace RazorSample.Pages.Admin.QLChuyenDe
{
    public class IndexModel : PageModel
    {
        private readonly IChuyenDeService _ChuyenDeService;
        public IndexModel(IChuyenDeService ChuyenDeService)
        {
            _ChuyenDeService = ChuyenDeService;
        }
        [BindProperty(SupportsGet = true)]
        public ChuyenDe ChuyenDe { get; set; }

        public ChuyenDeVM ChuyenDeVM { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        [BindProperty(SupportsGet = true)]
        public string Genre { get; set; }
        public void OnGet(string searchString, string genre, int pageIndex = 1)
        {
            searchString = SearchString;
            genre = Genre;
            ChuyenDeVM = _ChuyenDeService.GetChuyenDeViewModel(searchString, genre, pageIndex);
        }
    }
}