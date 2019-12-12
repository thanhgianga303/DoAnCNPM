using System.Collections.Generic;
using ApplicationCore.Entities;

namespace ApplicationCore.Interfaces
{
    public interface ICapBacRepository : IRepository<CapBac>
    {
        IEnumerable<CapBac> GetViewDSCapBac(string search, string genre);
    }
}