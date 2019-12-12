using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApplicationCore.Interfaces;

namespace ApplicationCore.Entities
{
    public class DieuLuat : IAggregateRoot
    {
        public int DieuLuatID { get; set; }
        public string MaDieuLuat { get; set; }
        public string Ten { get; set; }
        public string TienPhat { get; set; }

        public List<ChiTietBienBan> DanhSachChiTietBienBan { get; set; }
    }
}
