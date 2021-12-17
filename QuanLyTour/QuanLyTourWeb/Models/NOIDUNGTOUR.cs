namespace QuanLyTourWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NOIDUNGTOUR")]
    public partial class NOIDUNGTOUR
    {
        [Key]
        [StringLength(10)]
        [Display(Name = "Mã đoàn")]
        public string MaDoan { get; set; }

        [StringLength(20)]
        [Display(Name = "Hành trình")]
        public string HanhTrinh { get; set; }

        [StringLength(20)]
        [Display(Name = "Khách sạn")]
        public string KhachSan { get; set; }

        [StringLength(50)]
        [Display(Name = "Địa điểm tham quan")]
        public string DiaDiemThamQuan { get; set; }

        public virtual DOANDULICH DOANDULICH { get; set; }
    }
}
