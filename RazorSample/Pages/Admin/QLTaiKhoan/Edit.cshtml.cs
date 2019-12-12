using ApplicationCore.Entities;
using Infrastructure.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorSample.Services.Service;
using RazorSample.Services.IService;
using RazorSample.ViewModels;
using System;
namespace RazorSample.Pages.Admin.QLTaiKhoan
{
    public class EditModel : PageModel
    {
        private readonly ITaiKhoanService _TaiKhoanService;
        public EditModel(ITaiKhoanService TaiKhoanService)
        {
            _TaiKhoanService = TaiKhoanService;
        }
        public TaiKhoanVM TaiKhoanVM { get; set; }
        [BindProperty(SupportsGet = true)]
        public TaiKhoan TaiKhoan { get; set; }
        public void OnGet(int id)
        {
            TaiKhoan = _TaiKhoanService.GetTaiKhoan(id);
        }
        public IActionResult OnPost(int id)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _TaiKhoanService.UpdateTaiKhoan(id, TaiKhoan);

            return RedirectToPage("Index");

        }
    }
}