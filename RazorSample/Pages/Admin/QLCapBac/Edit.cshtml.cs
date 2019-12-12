using ApplicationCore.Entities;
using Infrastructure.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorSample.Services.Service;
using RazorSample.Services.IService;
using RazorSample.ViewModels;
using System;
namespace RazorSample.Pages.Admin.QLCapBac
{
    public class EditModel : PageModel
    {
        private readonly ICapBacService _CapBacService;
        public EditModel(ICapBacService CapBacService)
        {
            _CapBacService = CapBacService;
        }
        [BindProperty]
        public CapBac CapBac { get; set; }
        public IActionResult OnGet(int id)
        {
            CapBac = _CapBacService.GetCapBac(id);
            if (CapBac == null)
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
            _CapBacService.UpdateCapBac(id, CapBac);

            return RedirectToPage("Index");

        }
    }
}