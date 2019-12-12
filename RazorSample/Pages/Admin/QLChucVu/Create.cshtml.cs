using ApplicationCore.Entities;
using Infrastructure.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorSample.Services.Service;
using RazorSample.Services.IService;
using RazorSample.ViewModels;
namespace RazorSample.Pages.Admin.QLChucVu
{
    public class CreateModel : PageModel
    {
        private readonly IChucVuService _ChucVuService;
        public CreateModel(IChucVuService ChucVuService)
        {
            _ChucVuService=ChucVuService;
        }
        
        [BindProperty(SupportsGet = true)]
        public ChucVuVM ChucVuVM{get;set;}

        [BindProperty(SupportsGet = true)]
        public ChucVu ChucVu{get;set;}
        
        public IActionResult OnPost()
        {
            _ChucVuService.AddChucVu(ChucVu);
            return RedirectToPage("Index");
        } 
    }
}