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
    public class CreateModel : PageModel
    {
        private readonly ICanBoService _CanBoService;
        public CreateModel(ICanBoService CanBoService)
        {
            _CanBoService = CanBoService;
        }
        [BindProperty(SupportsGet = true)]
        public CanBo CanBo { get; set; }

        public IActionResult OnPost()
        {
            _CanBoService.AddCanBo(CanBo);
            return RedirectToPage("Index");
        }
    }
}