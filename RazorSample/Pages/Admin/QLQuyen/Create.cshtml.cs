using ApplicationCore.Entities;
using Infrastructure.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorSample.Services.Service;
using RazorSample.Services.IService;
using RazorSample.ViewModels;
namespace RazorSample.Pages.Admin.QLQuyen
{
    public class CreateModel : PageModel
    {
        private readonly IQuyenService _QuyenService;
        public CreateModel(IQuyenService QuyenService)
        {
            _QuyenService=QuyenService;
        }
        
        [BindProperty(SupportsGet = true)]
        public QuyenVM QuyenVM{get;set;}

        [BindProperty(SupportsGet = true)]
        public Quyen Quyen{get;set;}
        
        public IActionResult OnPost()
        {
            _QuyenService.AddQuyen(Quyen);
            return RedirectToPage("Index");
        } 
    }
}