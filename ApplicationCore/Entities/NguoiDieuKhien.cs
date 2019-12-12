using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApplicationCore.Interfaces;
namespace ApplicationCore.Entities
{
    public class NguoiDieuKhien : IAggregateRoot
    {
        public int NguoiDieuKhienID { get; set; }
        public string Cmnd { get; set; }
        public string Ten { get; set; }
        public DateTime NgaySinh { get; set; }
        public string DiaChi { get; set; }

        public List<BienBan> ListBienBan { get; set; }
        public List<BangLai> BangLai { get; set; }
    }
}