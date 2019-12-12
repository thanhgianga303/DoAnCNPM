using System.Collections.Generic;
using ApplicationCore.Entities;

namespace ApplicationCore.Interfaces
{
    public interface IDieuLuatRepository : IRepository<DieuLuat>
    {
        IEnumerable<DieuLuat> GetViewDSDieuLuat(string search, string genre);
    }
}