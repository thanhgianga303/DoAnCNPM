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
    public class DeleteModel : PageModel
    {
        private readonly IDieuLuatService _DieuLuatService;
        public DeleteModel(IDieuLuatService DieuLuatService)
        {
            _DieuLuatService = DieuLuatService;
        }
        public DieuLuatVM DieuLuatVM { get; set; }
        [BindProperty(SupportsGet = true)]
        public DieuLuat DieuLuat { get; set; }
        public void OnGet(int id)
        {

            DieuLuat = _DieuLuatService.GetDieuLuat(id);
        }
        public IActionResult OnPost(int id)
        {
            _DieuLuatService.DeleteDieuLuat(id);

            return RedirectToPage("Index");

        }
    }
}