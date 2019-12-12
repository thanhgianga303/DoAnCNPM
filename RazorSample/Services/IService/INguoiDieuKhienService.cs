using ApplicationCore.Entities;
using RazorSample.ViewModels;
namespace RazorSample.Services.IService
{
    public interface INguoiDieuKhienService
    {
        NguoiDieuKhienVM GetNguoiDieuKhienViewModel(string SearchString, string Genre, int pageIndex);
        void DeleteNguoiDieuKhien(int id);
        NguoiDieuKhien GetNguoiDieuKhien(int id);
        void AddNguoiDieuKhien(NguoiDieuKhien NguoiDieuKhien);
        void UpdateNguoiDieuKhien(int id, NguoiDieuKhien NguoiDieuKhien);
    }
}