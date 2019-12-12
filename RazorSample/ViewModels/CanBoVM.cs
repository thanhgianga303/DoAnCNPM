using Microsoft.AspNetCore.Mvc.Rendering;
using ApplicationCore.Entities;
using System.Collections.Generic;
namespace RazorSample.ViewModels
{
    public class CanBoVM
    {
        public PaginatedList<CanBo> DanhSachCanBo { get; internal set; }
    }
}