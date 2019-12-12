using ApplicationCore.Entities;
using Infrastructure.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorSample.Services.Service;
using RazorSample.Services.IService;
using RazorSample.ViewModels;
namespace RazorSample.Pages.FrontPage.HomePage
{
    public class IndexModel : PageModel
    {
        private readonly IBienBanService _BienBanService;
        public IndexModel(IBienBanService BienBanService)
        {
            _BienBanService = BienBanService;
        }
        [BindProperty(SupportsGet = true)]
        public BienBan BienBan { get; set; }

        public BienBanVM BienBanVM { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        [BindProperty(SupportsGet = true)]
        public string Genre { get; set; }
        public void OnGet(string searchString, string genre, int pageIndex = 1)
        {
            searchString = SearchString;
            genre = Genre;
            BienBanVM = _BienBanService.GetBienBanViewModelForUser(searchString, genre, pageIndex);
        }
    }
}