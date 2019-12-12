using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using ApplicationCore.Interfaces;

namespace ApplicationCore.Entities
{
    public class TaiKhoan : IAggregateRoot
    {
        public int TaiKhoanID { get; set; }
        public int QuyenID { get; set; }
        
        [MinLength(5)]
        public string TenTaiKhoan { get; set; }
        public string MatKhau { get; set; }
        public int TrangThai { get; set; }
        public CanBo CanBo { get; set; }
        public Quyen Quyen { get; set; }
    }
}
