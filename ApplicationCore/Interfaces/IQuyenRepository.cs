using System.Collections.Generic;
using ApplicationCore.Entities;

namespace ApplicationCore.Interfaces
{
    public interface IQuyenRepository : IRepository<Quyen>
    {
        IEnumerable<Quyen> GetViewDSQuyen(string search, string genre);
    }
}