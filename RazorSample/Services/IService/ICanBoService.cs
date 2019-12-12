using ApplicationCore.Entities;
using RazorSample.ViewModels;

namespace RazorSample.Services.IService
{
    public interface ICanBoService
    {
        CanBoVM GetCanBoViewModel(string SearchString, string Genre, int pageIndex);
        void DeleteCanBo(int id);
        CanBo GetCanBo(int id);
        void AddCanBo(CanBo CanBo);
        void UpdateCanBo(int id, CanBo CanBo);
    }
}