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
    public class DeleteModel : PageModel
    {
        private readonly IDoiService _DoiService;
        public DeleteModel(IDoiService DoiService)
        {
            _DoiService = DoiService;
        }
        public DoiVM DoiVM { get; set; }
        [BindProperty(SupportsGet = true)]
        public Doi Doi { get; set; }
        public void OnGet(int id)
        {

            Doi = _DoiService.GetDoi(id);
        }
        public IActionResult OnPost(int id)
        {
            _DoiService.DeleteDoi(id);

            return RedirectToPage("Index");

        }
    }
}