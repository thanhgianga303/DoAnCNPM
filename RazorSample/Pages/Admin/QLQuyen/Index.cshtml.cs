using ApplicationCore.Entities;
using Infrastructure.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorSample.Services.Service;
using RazorSample.Services.IService;
using RazorSample.ViewModels;
namespace RazorSample.Pages.Admin.QLQuyen
{
    public class IndexModel : PageModel
    {
        private readonly IQuyenService _QuyenService;
        public IndexModel(IQuyenService QuyenService)
        {
            _QuyenService = QuyenService;
        }
        [BindProperty(SupportsGet = true)]
        public Quyen Quyen { get; set; }

        public QuyenVM QuyenVM { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        [BindProperty(SupportsGet = true)]
        public string Genre { get; set; }
        public void OnGet(string searchString, string genre, int pageIndex = 1)
        {
            searchString = SearchString;
            genre = Genre;
            QuyenVM = _QuyenService.GetQuyenViewModel(searchString, genre, pageIndex);
        }
    }
}