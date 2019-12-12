using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApplicationCore.Interfaces;


namespace ApplicationCore.Entities
{
    public class PhuongTien : IAggregateRoot
    {
        public int PhuongTienID { get; set; }
        public int TheLoaiPhuongTienID { get; set; }
        public string CaVet { get; set; }
        public string BKS { get; set; }
        public List<BienBan> DanhSachBienBan { get; set; }
        public TheLoaiPhuongTien TheLoaiPhuongTien { get; set; }
    }
}
