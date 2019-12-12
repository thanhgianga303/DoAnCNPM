using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApplicationCore.Interfaces;

namespace ApplicationCore.Entities
{
    public class BienBan : IAggregateRoot
    {
        public int BienBanID { get; set; }
        public int PhuongTienID { get; set; }
        public int NguoiDieuKhienID { get; set; }
        public int TuyenDuongID { get; set; }
        public string MaBienBan { get; set; }
        public DateTime ThoiGian { get; set; }
        public double TienPhat { get; set; }

        public CanBo CanBo { get; set; }
        public PhuongTien PhuongTien { get; set; }
        public NguoiDieuKhien NguoiDieuKhien { get; set; }
        public List<ChiTietBienBan> DanhSachChiTietBienBan { get; set; }
        public TuyenDuong TuyenDuong { get; set; }
    }
}
