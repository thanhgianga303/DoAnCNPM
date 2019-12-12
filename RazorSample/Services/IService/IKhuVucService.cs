using RazorSample.ViewModels;
using ApplicationCore.Entities;
namespace RazorSample.Services.IService
{
    public interface IKhuVucService
    {
        KhuVucVM GetKhuVucViewModel(string search, string genre, int pageIndex = 1);
        void DeleteKhuVuc(int id);
        KhuVuc GetKhuVuc(int id);
        void AddKhuVuc(KhuVuc KhuVuc);
        void UpdateKhuVuc(int id, KhuVuc KhuVuc);
    }
}