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
    public class DeleteModel : PageModel
    {
        private readonly IBangLaiService _BangLaiService;
        public DeleteModel(IBangLaiService BangLaiService)
        {
            _BangLaiService = BangLaiService;
        }
        public BangLaiVM BangLaiVM { get; set; }
        [BindProperty(SupportsGet = true)]
        public BangLai BangLai { get; set; }
        public void OnGet(int id)
        {

            BangLai = _BangLaiService.GetBangLai(id);
        }
        public IActionResult OnPost(int id)
        {
            _BangLaiService.DeleteBangLai(id);

            return RedirectToPage("Index");

        }
    }
}