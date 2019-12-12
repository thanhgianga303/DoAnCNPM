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
    public class DeleteModel : PageModel
    {
        private readonly ITheLoaiPhuongTienService _TheLoaiPhuongTienService;
        public DeleteModel(ITheLoaiPhuongTienService TheLoaiPhuongTienService)
        {
            _TheLoaiPhuongTienService = TheLoaiPhuongTienService;
        }
        public TheLoaiPhuongTienVM TheLoaiPhuongTienVM { get; set; }
        [BindProperty(SupportsGet = true)]
        public TheLoaiPhuongTien TheLoaiPhuongTien { get; set; }
        public void OnGet(int id)
        {

            TheLoaiPhuongTien = _TheLoaiPhuongTienService.GetTheLoaiPhuongTien(id);
        }
        public IActionResult OnPost(int id)
        {
            _TheLoaiPhuongTienService.DeleteTheLoaiPhuongTien(id);

            return RedirectToPage("Index");

        }
    }
}