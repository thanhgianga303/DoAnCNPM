using ApplicationCore.Entities;
using Infrastructure.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorSample.Services.Service;
using RazorSample.Services.IService;
using RazorSample.ViewModels;
namespace RazorSample.Pages.Admin.QLCanBo
{
    public class DeleteModel : PageModel
    {
        private readonly ICanBoService _CanBoService;
        public DeleteModel(ICanBoService CanBoService)
        {
            _CanBoService = CanBoService;
        }
        public CanBoVM CanBoVM { get; set; }
        [BindProperty(SupportsGet = true)]
        public CanBo CanBo { get; set; }
        public void OnGet(int id)
        {

            CanBo = _CanBoService.GetCanBo(id);
        }
        public IActionResult OnPost(int id)
        {
            _CanBoService.DeleteCanBo(id);

            return RedirectToPage("Index");

        }
    }
}