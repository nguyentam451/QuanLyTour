namespace QuanLyTourWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GIATOUR")]
    public partial class GIATOUR
    {
        [Key]
        [StringLength(10)]
        [Display(Name = "Mã Giá")]

        public string MaGia { get; set; }

        [StringLength(10)]
        [Display(Name = "Mã Tour")]
        public string MaTour { get; set; }

        [Display(Name = "Thành tiền")]
        public int? ThanhTien { get; set; }
        [Display(Name = "Thời gian bắt đầu")]

        public DateTime? ThoiGianBatDau { get; set; }
        [Display(Name = "Thời gian kết thúc")]

        public DateTime? ThoiGianKetThuc { get; set; }

        public virtual TOURDULICH TOURDULICH { get; set; }
    }
}
