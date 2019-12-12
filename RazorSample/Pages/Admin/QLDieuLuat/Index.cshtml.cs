using ApplicationCore.Entities;
using Infrastructure.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorSample.Services.Service;
using RazorSample.Services.IService;
using RazorSample.ViewModels;
namespace RazorSample.Pages.Admin.QLDieuLuat
{
    public class IndexModel : PageModel
    {
        private readonly IDieuLuatService _DieuLuatService;
        public IndexModel(IDieuLuatService DieuLuatService)
        {
            _DieuLuatService = DieuLuatService;
        }
        [BindProperty(SupportsGet = true)]
        public DieuLuat DieuLuat { get; set; }
        public DieuLuatVM DieuLuatVM { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        [BindProperty(SupportsGet = true)]
        public string Genre { get; set; }
        public void OnGet(string searchString, string genre, int pageIndex = 1)
        {
            searchString = SearchString;
            genre = Genre;
            DieuLuatVM = _DieuLuatService.GetDieuLuatViewModel(searchString, genre, pageIndex);
        }

    }
}