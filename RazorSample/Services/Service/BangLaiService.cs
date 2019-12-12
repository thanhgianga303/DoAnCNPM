using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorSample.ViewModels;
using RazorSample.Services.IService;

namespace RazorSample.Services.Service
{
    public class BangLaiService : IBangLaiService
    {
        private int pageSize = 3;
        private readonly IUnitOfWork _unitOfWork;

        public BangLaiService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public BangLaiVM GetBangLaiViewModel(string SearchString, string Genre, int pageIndex = 1)
        {
            var DSBangLai = _unitOfWork.DanhSachBangLai.GetViewDSBangLai(SearchString, Genre);
            return new BangLaiVM
            {
                DanhSachBangLai = PaginatedList<BangLai>.Create(DSBangLai, pageIndex, pageSize),
            };
        }

        public void DeleteBangLai(int id)
        {
            var BangLai = _unitOfWork.DanhSachBangLai.GetBy(id);
            if (BangLai != null)
            {
                _unitOfWork.DanhSachBangLai.Remove(BangLai);
                _unitOfWork.Complete();
            }
        }
        public void AddBangLai(BangLai BangLai)
        {
            _unitOfWork.DanhSachBangLai.Add(BangLai);
            _unitOfWork.Complete();
        }
        public void UpdateBangLai(int id, BangLai BangLai)
        {
            var _BangLai = _unitOfWork.DanhSachBangLai.GetBy(id);
            if (_BangLai != null)
            {
                _BangLai.MaBangLai = BangLai.MaBangLai;
                _BangLai.NgayCap = BangLai.NgayCap;
                _BangLai.HanSuDung = BangLai.HanSuDung;
            }
            _unitOfWork.Complete();
        }
        public BangLai GetBangLai(int id)
        {
            var _BangLai = _unitOfWork.DanhSachBangLai.GetBy(id);
            return _BangLai;
        }
    }
}