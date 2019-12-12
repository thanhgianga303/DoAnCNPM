using System.Collections.Generic;
using ApplicationCore.Entities;

namespace ApplicationCore.Interfaces
{
    public interface IChuyenDeRepository : IRepository<ChuyenDe>
    {
        IEnumerable<ChuyenDe> GetViewDSChuyenDe(string search, string genre);
    }
}