using System.Collections.Generic;
using ApplicationCore.Interfaces;

namespace ApplicationCore.Entities
{
    public class TuyenDuong : IAggregateRoot
    {
        public int TuyenDuongID { get; set; }
        public int KhuVucID { get; set; }
        public string MaTuyenDuong { get; set; }
        public string TenTuyenDuong { get; set; }
        public List<BienBan> DanhSachBienBan { get; set; }
    }
}