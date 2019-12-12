using ApplicationCore.Entities;
using Infrastructure.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorSample.Services.Service;
using RazorSample.Services.IService;
using RazorSample.ViewModels;
namespace RazorSample.Pages.Admin.QLKhuVuc
{
    public class CreateModel : PageModel
    {
        private readonly IKhuVucService _KhuVucService;
        public CreateModel(IKhuVucService KhuVucService)
        {
            _KhuVucService = KhuVucService;
        }
        [BindProperty(SupportsGet = true)]
        public KhuVuc KhuVuc { get; set; }

        public IActionResult OnPost()
        {
            _KhuVucService.AddKhuVuc(KhuVuc);
            return RedirectToPage("Index");
        }
    }
}