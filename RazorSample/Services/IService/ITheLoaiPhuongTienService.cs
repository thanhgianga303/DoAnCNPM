using RazorSample.ViewModels;
using ApplicationCore.Entities;
namespace RazorSample.Services.IService
{
    public interface ITheLoaiPhuongTienService
    {
        TheLoaiPhuongTienVM GetTheLoaiPhuongTienViewModel(string SearchString, string Genre, int pageIndex);
        void DeleteTheLoaiPhuongTien(int id);
        TheLoaiPhuongTien GetTheLoaiPhuongTien(int id);
        void AddTheLoaiPhuongTien(TheLoaiPhuongTien TheLoaiPhuongTien);
        void UpdateTheLoaiPhuongTien(int id, TheLoaiPhuongTien TheLoaiPhuongTien);
    }
}