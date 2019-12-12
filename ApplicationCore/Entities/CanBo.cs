using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApplicationCore.Interfaces;

namespace ApplicationCore.Entities
{
    public class CanBo : IAggregateRoot
    {
        public int CanBoID { get; set; }
        public int ChucVuID { get; set; }
        public int DoiID { get; set; }
        public int TaiKhoanID { get; set; }
        public int CapBacID { get; set; }
        public string MaCanBo { get; set; }
        public string Ten { get; set; }
        public int TrangThai { get; set; }

        public ChucVu ChucVu { get; set; }
        public Doi Doi { get; set; }
        public List<BienBan> DanhSachBienBan { get; set; }
        public CapBac CapBac { get; set; }
        public TaiKhoan TaiKhoan { get; set; }
    }
}
