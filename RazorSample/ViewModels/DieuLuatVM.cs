using Microsoft.AspNetCore.Mvc.Rendering;
using ApplicationCore.Entities;
using System.Collections.Generic;
namespace RazorSample.ViewModels
{
    public class DieuLuatVM
    {
        public PaginatedList<DieuLuat> DanhSachDieuLuat { get; internal set; }
        public DieuLuat DieuLuat { get; internal set; }
    }
}