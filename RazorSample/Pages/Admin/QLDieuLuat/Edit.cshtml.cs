using ApplicationCore.Entities;
using Infrastructure.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorSample.Services.Service;
using RazorSample.Services.IService;
using RazorSample.ViewModels;
using System;
namespace RazorSample.Pages.Admin.QLDieuLuat
{
    public class EditModel : PageModel
    {
        private readonly IDieuLuatService _DieuLuatService;
        public EditModel(IDieuLuatService DieuLuatService)
        {
            _DieuLuatService = DieuLuatService;
        }
        [BindProperty]
        public DieuLuat DieuLuat { get; set; }
        public IActionResult OnGet(int id)
        {
            DieuLuat = _DieuLuatService.GetDieuLuat(id);
            if (DieuLuat == null)
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
            _DieuLuatService.UpdateDieuLuat(id, DieuLuat);

            return RedirectToPage("Index");

        }
    }
}