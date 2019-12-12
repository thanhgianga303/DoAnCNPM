using RazorSample.ViewModels;
using ApplicationCore.Entities;
namespace RazorSample.Services.IService
{
    public interface ITuyenDuongService
    {
        TuyenDuongVM GetTuyenDuongViewModel(string SearchString, string Genre, int pageIndex);
        void DeleteTuyenDuong(int id);
        TuyenDuong GetTuyenDuong(int id);
        void AddTuyenDuong(TuyenDuong TuyenDuong);
        void UpdateTuyenDuong(int id, TuyenDuong TuyenDuong);
    }
}