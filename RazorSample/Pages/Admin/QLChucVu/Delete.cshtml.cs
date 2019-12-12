using ApplicationCore.Entities;
using Infrastructure.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorSample.Services.Service;
using RazorSample.Services.IService;
using RazorSample.ViewModels;
namespace RazorSample.Pages.Admin.QLChucVu
{
    public class DeleteModel : PageModel
    {
        private readonly IChucVuService _ChucVuService;
        public DeleteModel(IChucVuService ChucVuService)
        {
            _ChucVuService = ChucVuService;
        }
        public ChucVuVM ChucVuVM { get; set; }
        [BindProperty(SupportsGet = true)]
        public ChucVu ChucVu { get; set; }
        public void OnGet(int id)
        {
            ChucVu = _ChucVuService.GetChucVu(id);
        }
        public IActionResult OnPost(int id)
        {
            _ChucVuService.DeleteChucVu(id);

            return RedirectToPage("Index");

        }
    }
}