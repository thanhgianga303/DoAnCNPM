using ApplicationCore.Entities;
using Infrastructure.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorSample.Services.Service;
using RazorSample.Services.IService;
using RazorSample.ViewModels;
namespace RazorSample.Pages.Admin.QLNguoiDieuKhien
{
    public class DeleteModel : PageModel
    {
        private readonly INguoiDieuKhienService _NguoiDieuKhienService;
        public DeleteModel(INguoiDieuKhienService NguoiDieuKhienService)
        {
            _NguoiDieuKhienService = NguoiDieuKhienService;
        }
        public NguoiDieuKhienVM NguoiDieuKhienVM { get; set; }
        [BindProperty(SupportsGet = true)]
        public NguoiDieuKhien NguoiDieuKhien { get; set; }
        public void OnGet(int id)
        {

            NguoiDieuKhien = _NguoiDieuKhienService.GetNguoiDieuKhien(id);
        }
        public IActionResult OnPost(int id)
        {
            _NguoiDieuKhienService.DeleteNguoiDieuKhien(id);

            return RedirectToPage("Index");

        }
    }
}