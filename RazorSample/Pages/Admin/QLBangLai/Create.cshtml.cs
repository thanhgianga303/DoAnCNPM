using ApplicationCore.Entities;
using Infrastructure.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorSample.Services.Service;
using RazorSample.Services.IService;
using RazorSample.ViewModels;
namespace RazorSample.Pages.Admin.QLBangLai
{
    public class CreateModel : PageModel
    {
        private readonly IBangLaiService _BangLaiService;
        public CreateModel(IBangLaiService BangLaiService)
        {
            _BangLaiService = BangLaiService;
        }
        [BindProperty(SupportsGet = true)]
        public BangLai BangLai { get; set; }

        public IActionResult OnPost()
        {
            _BangLaiService.AddBangLai(BangLai);
            return RedirectToPage("Index");
        }
    }
}