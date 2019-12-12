using ApplicationCore.Entities;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace RazorSample.ViewModels
{
    public class PhuongTienVM
    {
        public PaginatedList<PhuongTien> DanhSachPhuongTien { get; internal set; }
        public PhuongTien PhuongTien { get; internal set; }
    }
}