using ApplicationCore.Entities;
using Infrastructure.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorSample.Services.Service;
using RazorSample.Services.IService;
using RazorSample.ViewModels;
using Microsoft.AspNetCore.Http;

namespace RazorSample.Pages.Login
{
    public class IndexModel : PageModel
    {
        private readonly ITaiKhoanService _TaiKhoanService;
        public IndexModel(ITaiKhoanService TaiKhoanService)
        {
            _TaiKhoanService = TaiKhoanService;
        }
        [BindProperty(SupportsGet = true)]
        public TaiKhoan TaiKhoan { get; set; }

        public TaiKhoanVM TaiKhoanVM { get; set; }
        [BindProperty(SupportsGet = true)]
        public string username { get; set; }
        [BindProperty(SupportsGet = true)]
        public string password { get; set; }
        public void OnGet()
        {

        }
        public IActionResult OnPost()
        {
            if (_TaiKhoanService.KiemTraTaiKhoan(username, password) == true)
            {
                // var TenCanBo = _TaiKhoanService.TaiKhoanKiemTra(username, password).CanBo.Ten;
                var role = _TaiKhoanService.TaiKhoanKiemTra(username, password).Quyen.QuyenID.ToString();
                HttpContext.Session.SetString("Username", username);
                // HttpContext.Session.SetString("TenCanBo", TenCanBo);
                HttpContext.Session.SetString("Role", role);
                return RedirectToPage("../Admin/Index");
            }
            else
            {
                @ViewData["Error"] = "Tên đăng nhập hoặc mật khẩu không hợp lệ";
                return Page();
            }
        }
    }
}