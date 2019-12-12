using System.Collections.Generic;
using ApplicationCore.Entities;

namespace ApplicationCore.Interfaces
{
    public interface IBangLaiRepository : IRepository<BangLai>
    {
        IEnumerable<BangLai> GetViewDSBangLai(string search, string genre);
    }
}