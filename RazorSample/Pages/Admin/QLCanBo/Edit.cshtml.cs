using ApplicationCore.Entities;
using Infrastructure.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorSample.Services.Service;
using RazorSample.Services.IService;
using RazorSample.ViewModels;
using System;
namespace RazorSample.Pages.Admin.QLCanBo
{
    public class EditModel : PageModel
    {
        private readonly ICanBoService _CanBoService;
        public EditModel(ICanBoService CanBoService)
        {
            _CanBoService = CanBoService;
        }
        [BindProperty]
        public CanBo CanBo { get; set; }
        public IActionResult OnGet(int id)
        {
            CanBo = _CanBoService.GetCanBo(id);
            if (CanBo == null)
            {
                return NotFound();
            }
            return Page();
        }
        public IActionResult OnPost(int id)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _CanBoService.UpdateCanBo(id, CanBo);

            return RedirectToPage("Index");

        }
    }
}