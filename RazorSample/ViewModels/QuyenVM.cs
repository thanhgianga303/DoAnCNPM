using Microsoft.AspNetCore.Mvc.Rendering;
using ApplicationCore.Entities;
using System.Collections.Generic;
namespace RazorSample.ViewModels
{
    public class QuyenVM
    {
        public PaginatedList<Quyen> DanhSachQuyen { get; internal set; }
        public Quyen Quyen{get;internal set;}
        public List<Quyen> DSQuyen{get;internal set;}
    }
}