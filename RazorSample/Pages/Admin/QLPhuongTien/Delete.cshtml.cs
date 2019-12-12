using ApplicationCore.Entities;
using Infrastructure.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorSample.Services.Service;
using RazorSample.Services.IService;
using RazorSample.ViewModels;
namespace RazorSample.Pages.Admin.QLPhuongTien
{
    public class DeleteModel : PageModel
    {
        private readonly IPhuongTienService _PhuongTienService;
        public DeleteModel(IPhuongTienService PhuongTienService)
        {
            _PhuongTienService = PhuongTienService;
        }
        public PhuongTienVM PhuongTienVM { get; set; }
        [BindProperty(SupportsGet = true)]
        public PhuongTien PhuongTien { get; set; }
        public void OnGet(int id)
        {

            PhuongTien = _PhuongTienService.GetPhuongTien(id);
        }
        public IActionResult OnPost(int id)
        {
            _PhuongTienService.DeletePhuongTien(id);

            return RedirectToPage("Index");

        }
    }
}