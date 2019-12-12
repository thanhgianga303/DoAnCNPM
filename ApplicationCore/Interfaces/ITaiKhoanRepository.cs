using System.Collections.Generic;
using ApplicationCore.Entities;

namespace ApplicationCore.Interfaces
{
    public interface ITaiKhoanRepository : IRepository<TaiKhoan>
    {
        IEnumerable<TaiKhoan> GetViewDSTaiKhoan(string search, string genre);
        TaiKhoan GetTaiKhoan(string username, string password);
    }
}