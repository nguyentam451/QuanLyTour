namespace QuanLyTourWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CHIPHI")]
    public partial class CHIPHI
    {
        [Key]
        [StringLength(10)]
        public string MaChiPhi { get; set; }

        [StringLength(10)]
        public string MaDoan { get; set; }

        public int? SoTien { get; set; }

        [StringLength(10)]
        public string MaLoaiChiPhi { get; set; }

        public virtual DOANDULICH DOANDULICH { get; set; }

        public virtual LOAICHIPHI LOAICHIPHI { get; set; }
    }
}
