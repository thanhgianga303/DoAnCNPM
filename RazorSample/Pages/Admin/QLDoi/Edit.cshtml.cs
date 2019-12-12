using ApplicationCore.Entities;
using Infrastructure.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorSample.Services.Service;
using RazorSample.Services.IService;
using RazorSample.ViewModels;
using System;
namespace RazorSample.Pages.Admin.QLDoi
{
    public class EditModel : PageModel
    {
        private readonly IDoiService _DoiService;
        public EditModel(IDoiService DoiService)
        {
            _DoiService = DoiService;
        }
        [BindProperty]
        public Doi Doi { get; set; }
        public IActionResult OnGet(int id)
        {
            Doi = _DoiService.GetDoi(id);
            if (Doi == null)
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
            _DoiService.UpdateDoi(id, Doi);

            return RedirectToPage("Index");

        }
    }
}