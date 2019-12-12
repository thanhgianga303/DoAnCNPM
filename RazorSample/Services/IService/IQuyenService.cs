using ApplicationCore.Entities;
using RazorSample.ViewModels;
namespace RazorSample.Services.IService
{
    public interface IQuyenService
    {
        QuyenVM GetQuyenViewModel(string SearchString, string Genre, int pageIndex);
        void DeleteQuyen(int id);
        Quyen GetQuyen(int id);
        void AddQuyen(Quyen Quyen);
        void UpdateQuyen(int id, Quyen Quyen);
    }
}