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
    public class DeleteModel : PageModel
    {
        private readonly ICapBacService _CapBacService;
        public DeleteModel(ICapBacService CapBacService)
        {
            _CapBacService = CapBacService;
        }
        public CapBacVM CapBacVM { get; set; }
        [BindProperty(SupportsGet = true)]
        public CapBac CapBac { get; set; }
        public void OnGet(int id)
        {

            CapBac = _CapBacService.GetCapBac(id);
        }
        public IActionResult OnPost(int id)
        {
            _CapBacService.DeleteCapBac(id);

            return RedirectToPage("Index");

        }
    }
}