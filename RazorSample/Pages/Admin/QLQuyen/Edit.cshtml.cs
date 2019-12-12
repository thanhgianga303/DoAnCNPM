using ApplicationCore.Entities;
using Infrastructure.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorSample.Services.Service;
using RazorSample.Services.IService;
using RazorSample.ViewModels;
using System;
namespace RazorSample.Pages.Admin.QLQuyen
{
    public class EditModel : PageModel
    {
        private readonly IQuyenService _QuyenService;
        public EditModel(IQuyenService QuyenService)
        {
            _QuyenService = QuyenService;
        }
        public QuyenVM QuyenVM { get; set; }
        [BindProperty(SupportsGet = true)]
        public Quyen Quyen { get; set; }
        public void OnGet(int id)
        {
            Quyen = _QuyenService.GetQuyen(id);
        }
        public IActionResult OnPost(int id)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _QuyenService.UpdateQuyen(id, Quyen);

            return RedirectToPage("Index");

        }
    }
}