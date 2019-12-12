using ApplicationCore.Entities;
using Infrastructure.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorSample.Services.Service;
using RazorSample.Services.IService;
using RazorSample.ViewModels;
using Microsoft.AspNetCore.Http;
namespace RazorSample.Pages.Admin.QLBangLai
{
    public class IndexModel : PageModel
    {
        private readonly IBangLaiService _BangLaiService;
        public IndexModel(IBangLaiService BangLaiService)
        {
            _BangLaiService = BangLaiService;
        }
        [BindProperty(SupportsGet = true)]
        public BangLai BangLai { get; set; }

        public BangLaiVM BangLaiVM { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        [BindProperty(SupportsGet = true)]
        public string Genre { get; set; }
        public void OnGet(string searchString, string genre, int pageIndex = 1)
        {
            searchString = SearchString;
            genre = Genre;
            BangLaiVM = _BangLaiService.GetBangLaiViewModel(searchString, genre, pageIndex);
        }
    }
}