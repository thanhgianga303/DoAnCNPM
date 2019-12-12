using ApplicationCore.Entities;
using Infrastructure.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorSample.Services.Service;
using RazorSample.Services.IService;
using RazorSample.ViewModels;
using System;
namespace RazorSample.Pages.Admin.QLKhuVuc
{
    public class EditModel : PageModel
    {
        private readonly IKhuVucService _KhuVucService;
        public EditModel(IKhuVucService KhuVucService)
        {
            _KhuVucService = KhuVucService;
        }
        [BindProperty]
        public KhuVuc KhuVuc { get; set; }
        public IActionResult OnGet(int id)
        {
            KhuVuc = _KhuVucService.GetKhuVuc(id);
            if (KhuVuc == null)
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
            _KhuVucService.UpdateKhuVuc(id, KhuVuc);

            return RedirectToPage("Index");

        }
    }
}