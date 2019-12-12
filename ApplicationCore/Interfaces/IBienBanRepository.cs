using System.Collections.Generic;
using ApplicationCore.Entities;

namespace ApplicationCore.Interfaces
{
    public interface IBienBanRepository : IRepository<BienBan>
    {
        IEnumerable<BienBan> GetDanhSachBienBanHienThi();
        IEnumerable<ChiTietBienBan> GetDanhSachChiTietBienBan(int id);
        IEnumerable<BienBan> GetViewDSBienBan(string search, string genre);
        IEnumerable<BienBan> GetViewDSBienBanForUser(string search, string genre);
        void AddChiTietBienBan(ChiTietBienBan chitietbienban);
        void RemoveChiTietBienBan(ChiTietBienBan chitietbienban);
        ChiTietBienBan GetByID(int id);

        // void DeleteChiTietBienBan(ChiTietBienBan chitietbienban);
        // void UpdateTietBienBan(ChiTietBienBan chitietbienban);
    }
}