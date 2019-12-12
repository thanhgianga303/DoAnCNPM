using ApplicationCore.Entities;
using Infrastructure.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorSample.Services.Service;
using RazorSample.Services.IService;
using RazorSample.ViewModels;
namespace RazorSample.Pages.Admin.QLPhuongTien
{
    public class CreateModel : PageModel
    {
        private readonly IPhuongTienService _PhuongTienService;
        public CreateModel(IPhuongTienService PhuongTienService)
        {
            _PhuongTienService = PhuongTienService;
        }
        [BindProperty(SupportsGet = true)]
        public PhuongTien PhuongTien { get; set; }

        public IActionResult OnPost()
        {
            _PhuongTienService.AddPhuongTien(PhuongTien);
            return RedirectToPage("Index");
        }
    }
}