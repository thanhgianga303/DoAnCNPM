using RazorSample.ViewModels;
using ApplicationCore.Entities;
namespace RazorSample.Services.IService
{
    public interface IChuyenDeService
    {
        ChuyenDeVM GetChuyenDeViewModel(string SearchString, string Genre, int pageIndex);
        void DeleteChuyenDe(int id);
        ChuyenDe GetChuyenDe(int id);
        void AddChuyenDe(ChuyenDe ChuyenDe);
        void UpdateChuyenDe(int id, ChuyenDe ChuyenDe);
    }
}