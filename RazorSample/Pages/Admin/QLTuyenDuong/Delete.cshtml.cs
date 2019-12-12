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
    public class DeleteModel : PageModel
    {
        private readonly ITuyenDuongService _TuyenDuongService;
        public DeleteModel(ITuyenDuongService TuyenDuongService)
        {
            _TuyenDuongService = TuyenDuongService;
        }
        public TuyenDuongVM TuyenDuongVM { get; set; }
        [BindProperty(SupportsGet = true)]
        public TuyenDuong TuyenDuong { get; set; }
        public void OnGet(int id)
        {

            TuyenDuong = _TuyenDuongService.GetTuyenDuong(id);
        }
        public IActionResult OnPost(int id)
        {
            _TuyenDuongService.DeleteTuyenDuong(id);

            return RedirectToPage("Index");

        }
    }
}