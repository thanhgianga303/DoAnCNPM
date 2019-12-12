using ApplicationCore.Entities;
using Infrastructure.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorSample.Services.Service;
using RazorSample.Services.IService;
using RazorSample.ViewModels;
using System;
namespace RazorSample.Pages.Admin.QLNguoiDieuKhien
{
    public class EditModel : PageModel
    {
        private readonly INguoiDieuKhienService _NguoiDieuKhienService;
        public EditModel(INguoiDieuKhienService NguoiDieuKhienService)
        {
            _NguoiDieuKhienService = NguoiDieuKhienService;
        }
        [BindProperty]
        public NguoiDieuKhien NguoiDieuKhien { get; set; }
        public IActionResult OnGet(int id)
        {
            NguoiDieuKhien = _NguoiDieuKhienService.GetNguoiDieuKhien(id);
            if (NguoiDieuKhien == null)
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
            _NguoiDieuKhienService.UpdateNguoiDieuKhien(id, NguoiDieuKhien);

            return RedirectToPage("Index");

        }
    }
}