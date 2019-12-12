using ApplicationCore.Entities;
using Infrastructure.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorSample.Services.Service;
using RazorSample.Services.IService;
using RazorSample.ViewModels;
namespace RazorSample.Pages.Admin.QLBienBan.QLChiTietBienBan
{
    public class CreateModel : PageModel
    {
        private readonly IBienBanService _BienBanService;
        public CreateModel(IBienBanService BienBanService)
        {
            _BienBanService = BienBanService;
        }
        [BindProperty(SupportsGet = true)]
        public ChiTietBienBan ChiTietBienBan { get; set; }
        public IActionResult OnPost()
        {
            _BienBanService.AddChiTietBienBan(ChiTietBienBan);
            return RedirectToPage("../Index");
        }
    }
}