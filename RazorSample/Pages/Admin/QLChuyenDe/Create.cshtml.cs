using ApplicationCore.Entities;
using Infrastructure.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorSample.Services.Service;
using RazorSample.Services.IService;
using RazorSample.ViewModels;
namespace RazorSample.Pages.Admin.QLChuyenDe
{
    public class CreateModel : PageModel
    {
        private readonly IChuyenDeService _ChuyenDeService;
        public CreateModel(IChuyenDeService ChuyenDeService)
        {
            _ChuyenDeService = ChuyenDeService;
        }
        [BindProperty(SupportsGet = true)]
        public ChuyenDe ChuyenDe { get; set; }

        public IActionResult OnPost()
        {
            _ChuyenDeService.AddChuyenDe(ChuyenDe);
            return RedirectToPage("Index");
        }
    }
}