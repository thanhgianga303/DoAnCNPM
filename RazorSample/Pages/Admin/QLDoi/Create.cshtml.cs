using ApplicationCore.Entities;
using Infrastructure.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorSample.Services.Service;
using RazorSample.Services.IService;
using RazorSample.ViewModels;
namespace RazorSample.Pages.Admin.QLDoi
{
    public class CreateModel : PageModel
    {
        private readonly IDoiService _DoiService;
        public CreateModel(IDoiService DoiService)
        {
            _DoiService = DoiService;
        }
        [BindProperty(SupportsGet = true)]
        public Doi Doi { get; set; }

        public IActionResult OnPost()
        {
            _DoiService.AddDoi(Doi);
            return RedirectToPage("Index");
        }
    }
}