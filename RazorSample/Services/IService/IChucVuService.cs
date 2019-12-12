using RazorSample.ViewModels;
using ApplicationCore.Entities;
namespace RazorSample.Services.IService
{
    public interface IChucVuService
    {
        ChucVuVM GetChucVuViewModel(string SearchString, string Genre, int pageIndex);
        void DeleteChucVu(int id);
        ChucVu GetChucVu(int id);
        void AddChucVu(ChucVu ChucVu);
        void UpdateChucVu(int id, ChucVu ChucVu);
    }
}