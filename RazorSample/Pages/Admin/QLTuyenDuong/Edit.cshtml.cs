using ApplicationCore.Entities;
using Infrastructure.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorSample.Services.Service;
using RazorSample.Services.IService;
using RazorSample.ViewModels;
using System;
namespace RazorSample.Pages.Admin.QLTuyenDuong
{
    public class EditModel : PageModel
    {
        private readonly ITuyenDuongService _TuyenDuongService;
        public EditModel(ITuyenDuongService TuyenDuongService)
        {
            _TuyenDuongService = TuyenDuongService;
        }
        [BindProperty]
        public TuyenDuong TuyenDuong { get; set; }
        public IActionResult OnGet(int id)
        {
            TuyenDuong = _TuyenDuongService.GetTuyenDuong(id);
            if (TuyenDuong == null)
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
            _TuyenDuongService.UpdateTuyenDuong(id, TuyenDuong);

            return RedirectToPage("Index");

        }
    }
}