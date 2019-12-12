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
    public class DeleteModel : PageModel
    {
        private readonly IChuyenDeService _ChuyenDeService;
        public DeleteModel(IChuyenDeService ChuyenDeService)
        {
            _ChuyenDeService = ChuyenDeService;
        }
        public ChuyenDeVM ChuyenDeVM { get; set; }
        [BindProperty(SupportsGet = true)]
        public ChuyenDe ChuyenDe { get; set; }
        public void OnGet(int id)
        {

            ChuyenDe = _ChuyenDeService.GetChuyenDe(id);
        }
        public IActionResult OnPost(int id)
        {
            _ChuyenDeService.DeleteChuyenDe(id);

            return RedirectToPage("Index");

        }
    }
}