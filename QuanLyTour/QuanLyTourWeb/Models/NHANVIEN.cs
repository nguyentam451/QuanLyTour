namespace QuanLyTourWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NHANVIEN")]
    public partial class NHANVIEN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NHANVIEN()
        {
            PHANBONHANVIEN_DOAN = new HashSet<PHANBONHANVIEN_DOAN>();
        }

        [Key]
        [StringLength(10)]
        [Display(Name = "Mã Nhân Viên")]
        public string MaNhanVien { get; set; }

        [StringLength(20)]
        [Display(Name = "Tên Nhân Viên")]

        public string TenNhanVien { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHANBONHANVIEN_DOAN> PHANBONHANVIEN_DOAN { get; set; }
    }
}
