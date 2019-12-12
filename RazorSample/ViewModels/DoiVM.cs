using Microsoft.AspNetCore.Mvc.Rendering;
using ApplicationCore.Entities;
using System.Collections.Generic;
namespace RazorSample.ViewModels
{
    public class DoiVM
    {
        public PaginatedList<Doi> DanhSachDoi { get; internal set; }
        public Doi Doi { get; internal set; }

    }
}