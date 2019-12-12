using System.Collections.Generic;
using ApplicationCore.Entities;

namespace ApplicationCore.Interfaces
{
    public interface ITuyenDuongRepository : IRepository<TuyenDuong>
    {
        IEnumerable<TuyenDuong> GetViewDSTuyenDuong(string search, string genre);
    }
}