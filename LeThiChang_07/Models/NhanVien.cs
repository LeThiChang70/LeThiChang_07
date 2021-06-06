using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LeThiChang_07.Models
{
    [Table("NhanViens")]
    public class NhanVien
    {
        [Key]
        public string MaNhanVien { get; set; }
        public string HoTen { get; set; }
        public int MaPhongBan { get; set; }
    }
}