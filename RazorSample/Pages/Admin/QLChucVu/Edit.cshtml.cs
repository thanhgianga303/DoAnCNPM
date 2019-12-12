using ApplicationCore.Entities;
using Infrastructure.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorSample.Services.Service;
using RazorSample.Services.IService;
using RazorSample.ViewModels;
using System;
namespace RazorSample.Pages.Admin.QLChucVu
{
    public class EditModel : PageModel
    {
        private readonly IChucVuService _ChucVuService;
        public EditModel(IChucVuService ChucVuService)
        {
            _ChucVuService = ChucVuService;
        }
        [BindProperty(SupportsGet = true)]
        public ChucVu ChucVu { get; set; }
        public void OnGet(int id)
        {
            ChucVu = _ChucVuService.GetChucVu(id);
        }
        public IActionResult OnPost(int id)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _ChucVuService.UpdateChucVu(id, ChucVu);

            return RedirectToPage("Index");

        }
    }
}