using RazorSample.ViewModels;
using ApplicationCore.Entities;
namespace RazorSample.Services.IService
{
    public interface ICapBacService
    {
        CapBacVM GetCapBacViewModel(string SearchString, string Genre, int pageIndex);
        void DeleteCapBac(int id);
        CapBac GetCapBac(int id);
        void AddCapBac(CapBac CapBac);
        void UpdateCapBac(int id, CapBac CapBac);
    }
}