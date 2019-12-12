using ApplicationCore.Entities;
using Infrastructure.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorSample.Services.Service;
using RazorSample.Services.IService;
using RazorSample.ViewModels;
namespace RazorSample.Pages.Admin.QLBienBan
{
    public class DeleteModel : PageModel
    {
        private readonly IBienBanService _BienBanService;
        public DeleteModel(IBienBanService BienBanService)
        {
            _BienBanService = BienBanService;
        }
        public BienBanVM BienBanVM { get; set; }
        [BindProperty(SupportsGet = true)]
        public BienBan BienBan { get; set; }
        public void OnGet(int id)
        {

            BienBan = _BienBanService.GetBienBan(id);
        }
        public IActionResult OnPost(int id)
        {
            _BienBanService.DeleteBienBan(id);

            return RedirectToPage("Index");

        }
    }
}