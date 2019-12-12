using Microsoft.AspNetCore.Mvc.Rendering;
using ApplicationCore.Entities;
using System.Collections.Generic;
namespace RazorSample.ViewModels
{
    public class TuyenDuongVM
    {
        public PaginatedList<TuyenDuong> DanhSachTuyenDuong { get; internal set; }
        public TuyenDuong TuyenDuong{get;internal set;}
    }
}