using ApplicationCore.Entities;
using Infrastructure.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorSample.Services.Service;
using RazorSample.Services.IService;
using RazorSample.ViewModels;
using System;
namespace RazorSample.Pages.Admin.QLBienBan
{
    public class EditModel : PageModel
    {
        private readonly IBienBanService _BienBanService;
        public EditModel(IBienBanService BienBanService)
        {
            _BienBanService = BienBanService;
        }
        [BindProperty]
        public BienBan BienBan { get; set; }
        public IActionResult OnGet(int id)
        {
            BienBan = _BienBanService.GetBienBan(id);
            if (BienBan == null)
            {
                return NotFound();
            }
            return Page();
        }
        public IActionResult OnPost(int id)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _BienBanService.UpdateBienBan(id, BienBan);

            return RedirectToPage("Index");

        }
    }
}