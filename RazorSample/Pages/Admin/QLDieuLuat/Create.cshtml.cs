using ApplicationCore.Entities;
using Infrastructure.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorSample.Services.Service;
using RazorSample.Services.IService;
using RazorSample.ViewModels;
namespace RazorSample.Pages.Admin.QLDieuLuat
{
    public class CreateModel : PageModel
    {
        private readonly IDieuLuatService _DieuLuatService;
        public CreateModel(IDieuLuatService DieuLuatService)
        {
            _DieuLuatService = DieuLuatService;
        }
        [BindProperty(SupportsGet = true)]
        public DieuLuat DieuLuat { get; set; }

        public IActionResult OnPost()
        {
            _DieuLuatService.AddDieuLuat(DieuLuat);
            return RedirectToPage("Index");
        }
    }
}