using ApplicationCore.Entities;
using Infrastructure.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorSample.Services.Service;
using RazorSample.Services.IService;
using RazorSample.ViewModels;
using Microsoft.AspNetCore.Http;

namespace RazorSample.Pages.Admin.Logout
{
    public class IndexModel : PageModel
    {
        public IActionResult OnPost()
        {
            HttpContext.Session.Remove("Username");
            HttpContext.Session.Remove("Role");
            return RedirectToPage("../../Login/Index");
        }
    }
}