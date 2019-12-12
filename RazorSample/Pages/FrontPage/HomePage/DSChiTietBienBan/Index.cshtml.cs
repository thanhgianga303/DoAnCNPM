using ApplicationCore.Entities;
using Infrastructure.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorSample.Services.Service;
using RazorSample.Services.IService;
using RazorSample.ViewModels;
namespace RazorSample.Pages.FrontPage.HomePage.DSChiTietBienBan
{
    public class IndexModel : PageModel
    {
        private readonly IBienBanService _BienBanService;
        public IndexModel(IBienBanService BienBanService)
        {
            _BienBanService = BienBanService;
        }
        [BindProperty(SupportsGet = true)]
        public ChiTietBienBan ChiTietBienBan { get; set; }

        public ChiTietBienBanVM ChiTietBienBanVM { get; set; }
        public void OnGet(int id, int pageIndex = 1)
        {
            ChiTietBienBanVM = _BienBanService.GetChiTietBienBanViewModel(id, pageIndex);
        }
        
    }
}