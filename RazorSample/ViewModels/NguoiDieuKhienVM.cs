using ApplicationCore.Entities;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace RazorSample.ViewModels
{
    public class NguoiDieuKhienVM
    {
        public PaginatedList<NguoiDieuKhien> DanhSachNguoiDieuKhien { get; internal set; }
        public NguoiDieuKhien NguoiDieuKhien { get; internal set; }
    }
}