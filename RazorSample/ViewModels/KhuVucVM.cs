using Microsoft.AspNetCore.Mvc.Rendering;
using ApplicationCore.Entities;
using System.Collections.Generic;
namespace RazorSample.ViewModels
{
    public class KhuVucVM
    {
        public PaginatedList<KhuVuc> DanhSachKhuVuc { get; internal set; }
        public KhuVuc KhuVuc{get;internal set;}
    }
}