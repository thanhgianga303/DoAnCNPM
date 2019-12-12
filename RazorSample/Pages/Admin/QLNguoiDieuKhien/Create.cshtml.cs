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
    public class CreateModel : PageModel
    {
        private readonly INguoiDieuKhienService _NguoiDieuKhienService;
        public CreateModel(INguoiDieuKhienService NguoiDieuKhienService)
        {
            _NguoiDieuKhienService = NguoiDieuKhienService;
        }
        [BindProperty(SupportsGet = true)]
        public NguoiDieuKhien NguoiDieuKhien { get; set; }

        public IActionResult OnPost()
        {
            _NguoiDieuKhienService.AddNguoiDieuKhien(NguoiDieuKhien);
            return RedirectToPage("Index");
        }
    }
}