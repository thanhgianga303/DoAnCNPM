using ApplicationCore.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
namespace RazorSample.ViewModels
{
    public class BangLaiVM
    {
        public PaginatedList<BangLai> DanhSachBangLai { get; internal set; }
        public BangLai BangLai { get; internal set; }
    }
}