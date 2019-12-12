using Microsoft.AspNetCore.Mvc.Rendering;
using ApplicationCore.Entities;
using System.Collections.Generic;
namespace RazorSample.ViewModels
{
    public class ChucVuVM
    {
        public PaginatedList<ChucVu> DanhSachChucVu { get; internal set; }
        public ChucVu ChucVu{get;internal set;}
    }
}