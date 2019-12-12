using ApplicationCore.Entities;
using Infrastructure.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorSample.Services.Service;
using RazorSample.Services.IService;
using RazorSample.ViewModels;
using System;
namespace RazorSample.Pages.Admin.QLPhuongTien
{
    public class EditModel : PageModel
    {
        private readonly IPhuongTienService _PhuongTienService;
        public EditModel(IPhuongTienService PhuongTienService)
        {
            _PhuongTienService = PhuongTienService;
        }
        [BindProperty]
        public PhuongTien PhuongTien { get; set; }
        public IActionResult OnGet(int id)
        {
            PhuongTien = _PhuongTienService.GetPhuongTien(id);
            if (PhuongTien == null)
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
            _PhuongTienService.UpdatePhuongTien(id, PhuongTien);

            return RedirectToPage("Index");

        }
    }
}