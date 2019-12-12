using System.Collections.Generic;
using ApplicationCore.Entities;

namespace ApplicationCore.Interfaces
{
    public interface IDoiRepository : IRepository<Doi>
    {
        IEnumerable<Doi> GetViewDSDoi(string search, string genre);
    }
}