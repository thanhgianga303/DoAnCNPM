using ApplicationCore.Entities;
using RazorSample.ViewModels;
namespace RazorSample.Services.IService
{
    public interface IPhuongTienService
    {
        PhuongTienVM GetPhuongTienViewModel(string SearchString, string Genre, int pageIndex);
        void DeletePhuongTien(int id);
        PhuongTien GetPhuongTien(int id);
        void AddPhuongTien(PhuongTien PhuongTien);
        void UpdatePhuongTien(int id, PhuongTien PhuongTien);
    }
}