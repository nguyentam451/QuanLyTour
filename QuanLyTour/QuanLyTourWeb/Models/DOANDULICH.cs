namespace QuanLyTourWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DOANDULICH")]
    public partial class DOANDULICH
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DOANDULICH()
        {
            CHIPHI = new HashSet<CHIPHI>();
            PHANBONHANVIEN_DOAN = new HashSet<PHANBONHANVIEN_DOAN>();
            KHACH = new HashSet<KHACH>();
        }

        [Key]
        [StringLength(10)]
        public string MaDoan { get; set; }

        [StringLength(10)]
        [Display(Name = "Mã Tour")]

        public string MaTour { get; set; }

        [Display(Name = "Ngày Khởi Hành")]

        public DateTime? NgayKhoiHanh { get; set; }

        [Display(Name = "Ngày Kết thúc")]
        public DateTime? NgayKetThuc { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHIPHI> CHIPHI { get; set; }

        public virtual TOURDULICH TOURDULICH { get; set; }

        public virtual NOIDUNGTOUR NOIDUNGTOUR { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHANBONHANVIEN_DOAN> PHANBONHANVIEN_DOAN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KHACH> KHACH { get; set; }
    }
}
