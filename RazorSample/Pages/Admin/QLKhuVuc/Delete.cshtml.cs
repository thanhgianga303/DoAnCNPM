using ApplicationCore.Entities;
using Infrastructure.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorSample.Services.Service;
using RazorSample.Services.IService;
using RazorSample.ViewModels;
namespace RazorSample.Pages.Admin.QLKhuVuc
{
    public class DeleteModel : PageModel
    {
        private readonly IKhuVucService _KhuVucService;
        public DeleteModel(IKhuVucService KhuVucService)
        {
            _KhuVucService = KhuVucService;
        }
        public KhuVucVM KhuVucVM { get; set; }
        [BindProperty(SupportsGet = true)]
        public KhuVuc KhuVuc { get; set; }
        public void OnGet(int id)
        {

            KhuVuc = _KhuVucService.GetKhuVuc(id);
        }
        public IActionResult OnPost(int id)
        {
            _KhuVucService.DeleteKhuVuc(id);

            return RedirectToPage("Index");

        }
    }
}