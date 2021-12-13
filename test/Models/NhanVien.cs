using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace test.Models
{
    [Table("NhanViens")]
    public class NhanVien
    {
        [Key]
        public string NhanVienID { get; set; }
        [Display(Name = "Tên nhân viên")]
        public string TenNhanVien { get; set; }
        [Display(Name = "Số điện thoại")]
        public string SDT { get; set; }
        [Display(Name = "Tuổi")]
        public int Tuoi { get; set; }
    }
}