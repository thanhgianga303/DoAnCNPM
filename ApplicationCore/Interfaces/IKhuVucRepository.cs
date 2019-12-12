using System.Collections.Generic;
using ApplicationCore.Entities;

namespace ApplicationCore.Interfaces
{
    public interface IKhuVucRepository : IRepository<KhuVuc>
    {
        IEnumerable<KhuVuc> GetViewDSKhuVuc(string search, string genre);
        // IEnumerable<KhuVuc> GetSelect(int genre);
    }
}