using ApplicationCore.Entities;
using Infrastructure.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorSample.Services.Service;
using RazorSample.Services.IService;
using RazorSample.ViewModels;
using System;
namespace RazorSample.Pages.Admin.QLBangLai
{
    public class EditModel : PageModel
    {
        private readonly IBangLaiService _BangLaiService;
        public EditModel(IBangLaiService BangLaiService)
        {
            _BangLaiService = BangLaiService;
        }
        [BindProperty]
        public BangLai BangLai { get; set; }
        public IActionResult OnGet(int id)
        {
            BangLai = _BangLaiService.GetBangLai(id);
            if (BangLai == null)
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
            _BangLaiService.UpdateBangLai(id, BangLai);

            return RedirectToPage("Index");

        }
    }
}