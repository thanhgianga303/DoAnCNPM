using RazorSample.ViewModels;
using ApplicationCore.Entities;
namespace RazorSample.Services.IService
{
    public interface IBangLaiService
    {
        BangLaiVM GetBangLaiViewModel(string SearchString, string Genre, int pageIndex);
        void DeleteBangLai(int id);
        BangLai GetBangLai(int id);
        void AddBangLai(BangLai BangLai);
        void UpdateBangLai(int id, BangLai BangLai);
    }
}