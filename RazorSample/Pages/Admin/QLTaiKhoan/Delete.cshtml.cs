using ApplicationCore.Entities;
using Infrastructure.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorSample.Services.Service;
using RazorSample.Services.IService;
using RazorSample.ViewModels;
namespace RazorSample.Pages.Admin.QLTaiKhoan
{
    public class DeleteModel : PageModel
    {
        private readonly ITaiKhoanService _TaiKhoanService;
        public DeleteModel(ITaiKhoanService TaiKhoanService)
        {
            _TaiKhoanService = TaiKhoanService;
        }
        public TaiKhoanVM TaiKhoanVM { get; set; }
        [BindProperty(SupportsGet = true)]
        public TaiKhoan TaiKhoan { get; set; }
        public void OnGet(int id)
        {

            TaiKhoan = _TaiKhoanService.GetTaiKhoan(id);
        }
        public IActionResult OnPost(int id)
        {
            _TaiKhoanService.DeleteTaiKhoan(id);

            return RedirectToPage("Index");

        }
    }
}