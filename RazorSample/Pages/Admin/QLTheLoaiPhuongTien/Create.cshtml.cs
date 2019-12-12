using ApplicationCore.Entities;
using Infrastructure.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorSample.Services.Service;
using RazorSample.Services.IService;
using RazorSample.ViewModels;
namespace RazorSample.Pages.Admin.QLTheLoaiPhuongTien
{
    public class CreateModel : PageModel
    {
        private readonly ITheLoaiPhuongTienService _TheLoaiPhuongTienService;
        public CreateModel(ITheLoaiPhuongTienService TheLoaiPhuongTienService)
        {
            _TheLoaiPhuongTienService = TheLoaiPhuongTienService;
        }
        [BindProperty(SupportsGet = true)]
        public TheLoaiPhuongTien TheLoaiPhuongTien { get; set; }

        public IActionResult OnPost()
        {
            _TheLoaiPhuongTienService.AddTheLoaiPhuongTien(TheLoaiPhuongTien);
            return RedirectToPage("Index");
        }
    }
}