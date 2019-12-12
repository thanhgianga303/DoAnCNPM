using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApplicationCore.Interfaces;

namespace ApplicationCore.Entities
{
    public class ChiTietBienBan
    {
        public int ChiTietBienBanID { get; set; } //????
        public int DieuLuatID { get; set; }
        public int BienBanID { get; set; }
        public string MaChiTietBienBan { get; set; }//?????
        public BienBan BienBan { get; set; }
        public DieuLuat DieuLuat { get; set; }
    }
}
