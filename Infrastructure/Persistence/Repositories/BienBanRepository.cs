using System.Linq;
using System.Collections.Generic;
using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence.Repositories
{
    public class BienBanRepository : Repository<BienBan>, IBienBanRepository
    {
        public BienBanRepository(HeThongQuanLyVPGTContext context) : base(context)
        {
        }
        public IEnumerable<BienBan> GetViewDSBienBan(string search, string genre)
        {
            var dsbb = from m in HeThongQuanLyVPGTContext.DanhSachBienBan
                       select m;
            if (!string.IsNullOrEmpty(genre))
            {
                if (genre == "All")
                {
                    dsbb = dsbb.Where(m => m.MaBienBan.Contains(search)
                    || m.ThoiGian.ToString().Contains(search));
                }
                else
                if (genre == "MaBienBan")
                {
                    dsbb = dsbb.Where(m => m.MaBienBan.Contains(search));
                }
                else
                if (genre == "ThoiGian")
                {
                    dsbb = dsbb.Where(m => m.ThoiGian.ToString().Contains(search));
                }
            }
            return dsbb.ToList();
        }
        public IEnumerable<BienBan> GetViewDSBienBanForUser(string search, string genre)
        {
            var query1 = HeThongQuanLyVPGTContext.DanhSachBienBan
                        .Include("NguoiDieuKhien")
                        .Include("PhuongTien")
                        .Include("CanBo");
            if (!string.IsNullOrEmpty(genre))
            {
                if (genre == "XM")
                {
                    query1 = query1.Where(m => m.PhuongTien.BKS.Equals(search) && m.PhuongTien.TheLoaiPhuongTienID == 1);
                }
                else
                if (genre == "OT")
                {
                    query1 = query1.Where(m => m.PhuongTien.BKS.Equals(search) && m.PhuongTien.TheLoaiPhuongTienID == 2);
                }
            }
            else
            {
                query1 = query1.Where(m => m.MaBienBan.Equals(""));
            }
            return query1.ToList();
        }
        public IEnumerable<BienBan> GetDanhSachBienBanHienThi()
        {
            var query = HeThongQuanLyVPGTContext.DanhSachBienBan
                        .Include("NguoiDieuKhien")
                        .Include("PhuongTien")
                        .Include("CanBo");
            return query.ToList();
        }

        public IEnumerable<ChiTietBienBan> GetDanhSachChiTietBienBan(int id)
        {
            var query = HeThongQuanLyVPGTContext.DanhSachChiTietBienBan
            .Where(m => m.BienBanID == id)
            .Include("DieuLuat");
            
            return query.ToList();
        }
        public ChiTietBienBan GetByID(int id)
        {
            var Ctbienban=HeThongQuanLyVPGTContext.DanhSachChiTietBienBan.Find(id);
            return Ctbienban;
        }
        public void AddChiTietBienBan(ChiTietBienBan chitietbienban)
        {
            HeThongQuanLyVPGTContext.DanhSachChiTietBienBan.Add(chitietbienban);
        }
        public void RemoveChiTietBienBan(ChiTietBienBan chitietbienban)
        {
            HeThongQuanLyVPGTContext.DanhSachChiTietBienBan.Remove(chitietbienban);
        }
        // public void DelelteChiTietBienBan(ChiTietBienBan chitietbienban)
        // {   HeThongQuanLyVPGTContext.DanhSachChiTietBienBan.Remove(chitietbienban);
        // }
        // public void UpdateChiTietBienBan(ChiTietBienBan chitietbienban)
        // {
            
        // }
        protected HeThongQuanLyVPGTContext HeThongQuanLyVPGTContext
        {
            get { return Context as HeThongQuanLyVPGTContext; }
        }

    }
}