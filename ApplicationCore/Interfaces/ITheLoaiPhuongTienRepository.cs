using System.Collections.Generic;
using ApplicationCore.Entities;

namespace ApplicationCore.Interfaces
{
    public interface ITheLoaiPhuongTienRepository : IRepository<TheLoaiPhuongTien>
    {
        IEnumerable<TheLoaiPhuongTien> GetViewDSTheLoaiPhuongTien(string search, string genre);
    }
}