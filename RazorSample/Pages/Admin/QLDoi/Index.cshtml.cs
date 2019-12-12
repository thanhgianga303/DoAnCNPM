using ApplicationCore.Entities;
using Infrastructure.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorSample.Services.Service;
using RazorSample.Services.IService;
using RazorSample.ViewModels;
namespace RazorSample.Pages.Admin.QLDoi
{
    public class IndexModel : PageModel
    {
        private readonly IDoiService _DoiService;
        public IndexModel(IDoiService DoiService)
        {
            _DoiService = DoiService;
        }
        [BindProperty(SupportsGet = true)]
        public Doi Doi { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        [BindProperty(SupportsGet = true)]
        public string Genre { get; set; }
        public DoiVM DoiVM { get; set; }
        public void OnGet(string searchString, string genre, int pageIndex = 1)
        {
            searchString = SearchString;
            genre = Genre;
            DoiVM = _DoiService.GetDoiViewModel(searchString, genre, pageIndex);
        }
    }
}