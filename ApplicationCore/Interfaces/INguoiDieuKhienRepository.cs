using System.Collections.Generic;
using ApplicationCore.Entities;

namespace ApplicationCore.Interfaces
{
    public interface INguoiDieuKhienRepository : IRepository<NguoiDieuKhien>
    {
        IEnumerable<NguoiDieuKhien> GetViewDSNguoiDieuKhien(string search, string genre);
    }
}