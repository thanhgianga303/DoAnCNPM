using System.Collections.Generic;
using ApplicationCore.Entities;

namespace ApplicationCore.Interfaces
{
    public interface IChucVuRepository : IRepository<ChucVu>
    {
        IEnumerable<ChucVu> GetViewDSChucVu(string search, string genre);
    }
}