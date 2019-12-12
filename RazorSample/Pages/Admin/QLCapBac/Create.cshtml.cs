using ApplicationCore.Entities;
using Infrastructure.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorSample.Services.Service;
using RazorSample.Services.IService;
using RazorSample.ViewModels;
namespace RazorSample.Pages.Admin.QLCapBac
{
    public class CreateModel : PageModel
    {
        private readonly ICapBacService _CapBacService;
        public CreateModel(ICapBacService CapBacService)
        {
            _CapBacService = CapBacService;
        }
        [BindProperty(SupportsGet = true)]
        public CapBac CapBac { get; set; }

        public IActionResult OnPost()
        {
            _CapBacService.AddCapBac(CapBac);
            return RedirectToPage("Index");
        }
    }
}