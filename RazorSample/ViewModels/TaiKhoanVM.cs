using Microsoft.AspNetCore.Mvc.Rendering;
using ApplicationCore.Entities;
using System.Collections.Generic;
namespace RazorSample.ViewModels
{
    public class TaiKhoanVM
    {
        public PaginatedList<TaiKhoan> DanhSachTaiKhoan { get; internal set; }
        public TaiKhoan TaiKhoan{get;internal set;}

    }
}