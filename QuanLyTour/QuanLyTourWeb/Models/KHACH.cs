namespace QuanLyTourWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KHACH")]
    public partial class KHACH
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KHACH()
        {
            DOANDULICH = new HashSet<DOANDULICH>();
        }

        [Key]
        [StringLength(10)]
        [Display(Name = "Mã khách hàng")]
        public string MaKhachHang { get; set; }

        [StringLength(20)]
        [Display(Name = "Họ tên")]

        public string HoTen { get; set; }

        [StringLength(10)]
        [Display(Name = "Số CMND")]

        public string SoCMND { get; set; }

        [StringLength(50)]
        [Display(Name = "Địa chỉ")]

        public string DiaChi { get; set; }

        [StringLength(3)]
        [Display(Name = "Giới tính")]

        public string GioiTinh { get; set; }

        [StringLength(10)]
        [Display(Name = "Sđt")]

        public string SDT { get; set; }

        [StringLength(20)]
        [Display(Name = "Quốc tịch")]

        public string QuocTich { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DOANDULICH> DOANDULICH { get; set; }
    }
}
