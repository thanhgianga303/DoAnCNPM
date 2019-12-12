using Microsoft.AspNetCore.Mvc.Rendering;
using ApplicationCore.Entities;
using System.Collections.Generic;
namespace RazorSample.ViewModels
{
    public class ChiTietBienBanVM
    {
        public PaginatedList<ChiTietBienBan> DanhSachChiTietBienBan { get; internal set; }
    }
}