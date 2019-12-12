using System.Collections.Generic;
using ApplicationCore.Entities;

namespace ApplicationCore.Interfaces
{
    public interface IPhuongTienRepository : IRepository<PhuongTien>
    {
        // PhuongTien GetPhuongTien(string search, string loaixe);
        IEnumerable<PhuongTien> GetViewDSPhuongTien(string search, string genre);
    }
}