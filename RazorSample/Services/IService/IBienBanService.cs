using RazorSample.ViewModels;
using ApplicationCore.Entities;
namespace RazorSample.Services.IService
{
    public interface IBienBanService
    {
        BienBanVM GetBienBanViewModel(string SearchString, string Genre, int pageIndex);
        BienBanVM GetBienBanViewModelForUser(string SearchString, string Genre, int pageIndex);
        ChiTietBienBanVM GetChiTietBienBanViewModel(int id, int pageIndex);
        BienBan GetBienBan(int id);
        ChiTietBienBan GetChiTietBienBan(int id);
        void DeleteBienBan(int id);
        void DeleteChiTietBienBan(int id);
        void AddBienBan(BienBan BienBan);
        void AddChiTietBienBan(ChiTietBienBan ChiTietBienBan);
        void UpdateBienBan(int id, BienBan BienBan);
        void UpdateChiTietBienBan(int id, ChiTietBienBan ChiTietBienBan);
    }
}