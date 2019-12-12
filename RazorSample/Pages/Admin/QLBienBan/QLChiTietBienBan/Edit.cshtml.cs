using ApplicationCore.Entities;
using Infrastructure.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorSample.Services.Service;
using RazorSample.Services.IService;
using RazorSample.ViewModels;
using System;
namespace RazorSample.Pages.Admin.QLBienBan.QLChiTietBienBan
{
    public class EditModel : PageModel
    {
        private readonly IBienBanService _BienBanService;
        public EditModel(IBienBanService BienBanService)
        {
            _BienBanService = BienBanService;
        }
        [BindProperty]
        public ChiTietBienBan ChiTietBienBan { get; set; }
        public IActionResult OnGet(int id)
        {
            ChiTietBienBan = _BienBanService.GetChiTietBienBan(id);
            if (ChiTietBienBan == null)
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
            _BienBanService.UpdateChiTietBienBan(id, ChiTietBienBan);

            return RedirectToPage("../Index");

        }
    }
}