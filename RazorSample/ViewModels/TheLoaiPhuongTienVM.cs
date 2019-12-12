using Microsoft.AspNetCore.Mvc.Rendering;
using ApplicationCore.Entities;
using System.Collections.Generic;
namespace RazorSample.ViewModels
{
    public class TheLoaiPhuongTienVM
    {
        public PaginatedList<TheLoaiPhuongTien> DanhSachTheLoaiPhuongTien { get; internal set; }
        public TheLoaiPhuongTien TheLoaiPhuongTien{get;internal set;}
    }
}