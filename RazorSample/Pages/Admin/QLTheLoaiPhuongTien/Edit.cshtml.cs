using ApplicationCore.Entities;
using Infrastructure.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorSample.Services.Service;
using RazorSample.Services.IService;
using RazorSample.ViewModels;
using System;
namespace RazorSample.Pages.Admin.QLTheLoaiPhuongTien
{
    public class EditModel : PageModel
    {
        private readonly ITheLoaiPhuongTienService _TheLoaiPhuongTienService;
        public EditModel(ITheLoaiPhuongTienService TheLoaiPhuongTienService)
        {
            _TheLoaiPhuongTienService = TheLoaiPhuongTienService;
        }
        [BindProperty]
        public TheLoaiPhuongTien TheLoaiPhuongTien { get; set; }
        public IActionResult OnGet(int id)
        {
            TheLoaiPhuongTien = _TheLoaiPhuongTienService.GetTheLoaiPhuongTien(id);
            if (TheLoaiPhuongTien == null)
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
            _TheLoaiPhuongTienService.UpdateTheLoaiPhuongTien(id, TheLoaiPhuongTien);

            return RedirectToPage("Index");

        }
    }
}