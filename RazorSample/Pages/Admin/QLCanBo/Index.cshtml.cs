using ApplicationCore.Entities;
using Infrastructure.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorSample.Services.Service;
using RazorSample.Services.IService;
using RazorSample.ViewModels;
namespace RazorSample.Pages.Admin.QLCanBo
{
    public class IndexModel : PageModel
    {
        private readonly ICanBoService _CanBoService;
        public IndexModel(ICanBoService CanBoService)
        {
            _CanBoService = CanBoService;
        }
        [BindProperty(SupportsGet = true)]
        public CanBo CanBo { get; set; }

        public CanBoVM CanBoVM { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        [BindProperty(SupportsGet = true)]
        public string Genre { get; set; }
        public void OnGet(string searchString, string genre, int pageIndex = 1)
        {
            searchString = SearchString;
            genre = Genre;
            CanBoVM = _CanBoService.GetCanBoViewModel(searchString, genre, pageIndex);
        }
    }
}