using Microsoft.AspNetCore.Mvc.Rendering;
using ApplicationCore.Entities;
using System.Collections.Generic;
namespace RazorSample.ViewModels
{
    public class CapBacVM
    {
        public PaginatedList<CapBac> DanhSachCapBac { get; internal set; }
        public CapBac CapBac { get; internal set; }
    }
}