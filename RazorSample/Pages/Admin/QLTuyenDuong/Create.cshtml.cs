using ApplicationCore.Entities;
using Infrastructure.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorSample.Services.Service;
using RazorSample.Services.IService;
using RazorSample.ViewModels;
namespace RazorSample.Pages.Admin.QLTuyenDuong
{
    public class CreateModel : PageModel
    {
        private readonly ITuyenDuongService _TuyenDuongService;
        public CreateModel(ITuyenDuongService TuyenDuongService)
        {
            _TuyenDuongService = TuyenDuongService;
        }
        [BindProperty(SupportsGet = true)]
        public TuyenDuong TuyenDuong { get; set; }

        public IActionResult OnPost()
        {
            _TuyenDuongService.AddTuyenDuong(TuyenDuong);
            return RedirectToPage("Index");
        }
    }
}