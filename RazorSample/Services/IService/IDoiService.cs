using ApplicationCore.Entities;
using RazorSample.ViewModels;
namespace RazorSample.Services.IService
{
    public interface IDoiService
    {
        DoiVM GetDoiViewModel(string SearchString, string Genre, int pageIndex);
        void DeleteDoi(int id);
        Doi GetDoi(int id);
        void AddDoi(Doi Doi);
        void UpdateDoi(int id, Doi Doi);
    }
}