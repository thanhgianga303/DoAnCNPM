using ApplicationCore.Entities;
using Infrastructure.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorSample.Services.Service;
using RazorSample.Services.IService;
using RazorSample.ViewModels;
using System;
namespace RazorSample.Pages.Admin.QLChuyenDe
{
    public class EditModel : PageModel
    {
        private readonly IChuyenDeService _ChuyenDeService;
        public EditModel(IChuyenDeService ChuyenDeService)
        {
            _ChuyenDeService = ChuyenDeService;
        }
        [BindProperty]
        public ChuyenDe ChuyenDe { get; set; }
        public IActionResult OnGet(int id)
        {
            ChuyenDe = _ChuyenDeService.GetChuyenDe(id);
            if (ChuyenDe == null)
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
            _ChuyenDeService.UpdateChuyenDe(id, ChuyenDe);

            return RedirectToPage("Index");

        }
    }
}