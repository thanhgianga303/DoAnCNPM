using Microsoft.AspNetCore.Mvc.Rendering;
using ApplicationCore.Entities;
using System.Collections.Generic;
namespace RazorSample.ViewModels
{
    public class ChuyenDeVM
    {
        public PaginatedList<ChuyenDe> DanhSachChuyenDe { get; internal set; }
        public ChuyenDe ChuyenDe { get; internal set; }
    }
}