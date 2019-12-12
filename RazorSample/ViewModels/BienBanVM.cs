using ApplicationCore.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
namespace RazorSample.ViewModels
{
    public class BienBanVM
    {
        public PaginatedList<BienBan> DanhSachBienBan { get; internal set; }
        public PaginatedList<BienBan> DanhSachBienBanHienThi { get; internal set; }
        public BienBan BienBan { get; internal set; }

    }
}