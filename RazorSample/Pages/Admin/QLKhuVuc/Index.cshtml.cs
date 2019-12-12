using ApplicationCore.Entities;
using Infrastructure.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorSample.Services.Service;
using RazorSample.Services.IService;
using RazorSample.ViewModels;
namespace RazorSample.Pages.Admin.QLKhuVuc
{
    public class IndexModel : PageModel
    {
        private readonly IKhuVucService _KhuVucService;
        public IndexModel(IKhuVucService KhuVucService)
        {
            _KhuVucService = KhuVucService;
        }
        [BindProperty(SupportsGet = true)]
        public KhuVuc KhuVuc { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        [BindProperty(SupportsGet = true)]
        public string Genre { get; set; }

        public KhuVucVM KhuVucVM { get; set; }
        public void OnGet(string searchString,string genre,int pageIndex = 1)
        {
            searchString=SearchString;
            genre=Genre;
            KhuVucVM = _KhuVucService.GetKhuVucViewModel(searchString, genre, pageIndex);
        }
    }
}