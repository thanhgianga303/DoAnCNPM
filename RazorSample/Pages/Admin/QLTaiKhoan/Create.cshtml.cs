using ApplicationCore.Entities;
using Infrastructure.Persistence;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorSample.Services.Service;
using RazorSample.Services.IService;
using RazorSample.ViewModels;
namespace RazorSample.Pages.Admin.QLTaiKhoan
{
    public class CreateModel : PageModel
    {
        private readonly ITaiKhoanService _TaiKhoanService;
        public CreateModel(ITaiKhoanService TaiKhoanService)
        {
            _TaiKhoanService = TaiKhoanService;
        }

        [BindProperty(SupportsGet = true)]
        public TaiKhoanVM TaiKhoanVM { get; set; }

        [BindProperty(SupportsGet = true)]
        public TaiKhoan TaiKhoan { get; set; }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {   
                return Page();
            }
            else
            {
                _TaiKhoanService.AddTaiKhoan(TaiKhoan);
                return RedirectToPage("Index");
            }
        }
    }
}