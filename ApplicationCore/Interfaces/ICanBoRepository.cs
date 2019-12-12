using System.Collections.Generic;
using ApplicationCore.Entities;

namespace ApplicationCore.Interfaces
{
    public interface ICanBoRepository : IRepository<CanBo>
    {
        IEnumerable<CanBo> GetViewDSCanBo(string search, string genre);
    }
}