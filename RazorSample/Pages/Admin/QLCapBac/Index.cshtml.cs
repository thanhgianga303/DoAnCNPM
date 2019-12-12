using ApplicationCore.Entities;
using Infrastructure.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorSample.Services.Service;
using RazorSample.Services.IService;
using RazorSample.ViewModels;
namespace RazorSample.Pages.Admin.QLCapBac
{
    public class IndexModel : PageModel
    {
        private readonly ICapBacService _CapBacService;
        public IndexModel(ICapBacService CapBacService)
        {
            _CapBacService = CapBacService;
        }
        [BindProperty(SupportsGet = true)]
        public CapBac CapBac { get; set; }

        public CapBacVM CapBacVM { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        [BindProperty(SupportsGet = true)]
        public string Genre { get; set; }
        public void OnGet(string searchString, string genre, int pageIndex = 1)
        {
            searchString = SearchString;
            genre = Genre;
            CapBacVM = _CapBacService.GetCapBacViewModel(searchString, genre, pageIndex);
        }
    }
}