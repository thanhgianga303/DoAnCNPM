using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApplicationCore.Interfaces;

namespace ApplicationCore.Entities
{
    public class BangLai : IAggregateRoot
    {
        public int BangLaiID { get; set; }
        public int NguoiDieuKhienID { get; set; }

        public string MaBangLai { get; set; }
        public DateTime NgayCap { get; set; }
        public DateTime HanSuDung { get; set; }

        public NguoiDieuKhien NguoiDieuKhien { get; set; }

    }
}
