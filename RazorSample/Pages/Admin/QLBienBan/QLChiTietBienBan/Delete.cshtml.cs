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
    public class DeleteModel : PageModel
    {
        private readonly IBienBanService _BienBanService;
        public DeleteModel(IBienBanService BienBanService)
        {
            _BienBanService = BienBanService;
        }
        public ChiTietBienBanVM ChiTietBienBanVM { get; set; }
        [BindProperty(SupportsGet = true)]
        public ChiTietBienBan ChiTietBienBan { get; set; }
        public void OnGet(int id)
        {
            ChiTietBienBan = _BienBanService.GetChiTietBienBan(id);
        }
        public IActionResult OnPost(int id)
        {
            _BienBanService.DeleteChiTietBienBan(id);

            return RedirectToPage("../Index");

        }
    }
}