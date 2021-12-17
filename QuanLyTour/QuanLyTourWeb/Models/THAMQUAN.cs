namespace QuanLyTourWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("THAMQUAN")]
    public partial class THAMQUAN
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string MaTour { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string MaDiaDiem { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ThuTu { get; set; }

        public virtual DIADIEM DIADIEM { get; set; }

        public virtual TOURDULICH TOURDULICH { get; set; }
    }
}
