namespace QuanLyTourWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PHANBONHANVIEN_DOAN
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string MaNhanVien { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string MaDoan { get; set; }

        [StringLength(50)]
        public string NhiemVu { get; set; }

        public virtual DOANDULICH DOANDULICH { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }
    }
}
