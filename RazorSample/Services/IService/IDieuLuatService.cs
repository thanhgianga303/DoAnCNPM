using RazorSample.ViewModels;
using ApplicationCore.Entities;
namespace RazorSample.Services.IService
{
    public interface IDieuLuatService
    {
        DieuLuatVM GetDieuLuatViewModel(string SearchString, string Genre, int pageIndex);
        void DeleteDieuLuat(int id);
        DieuLuat GetDieuLuat(int id);
        void AddDieuLuat(DieuLuat DieuLuat);
        void UpdateDieuLuat(int id, DieuLuat DieuLuat);
    }
}