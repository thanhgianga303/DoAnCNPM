using RazorSample.ViewModels;
using ApplicationCore.Entities;
namespace RazorSample.Services.IService
{
    public interface ITaiKhoanService
    {
        TaiKhoanVM GetTaiKhoanViewModel(string SearchString, string Genre, int pageIndex);
        void DeleteTaiKhoan(int id);
        TaiKhoan GetTaiKhoan(int id);
        void AddTaiKhoan(TaiKhoan TaiKhoan);
        void UpdateTaiKhoan(int id, TaiKhoan TaiKhoan);
        bool KiemTraTaiKhoan(string username, string password);
        TaiKhoan TaiKhoanKiemTra(string username, string password);
    }
}