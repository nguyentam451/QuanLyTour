namespace QuanLyTourWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TOURDULICH")]
    public partial class TOURDULICH
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TOURDULICH()
        {
            DOANDULICH = new HashSet<DOANDULICH>();
            GIATOUR = new HashSet<GIATOUR>();
            THAMQUAN = new HashSet<THAMQUAN>();
        }

        [Key]
        [StringLength(10)]
        public string MaTour { get; set; }

        [StringLength(20)]
        public string TenGoi { get; set; }

        [StringLength(50)]
        public string DacDiem { get; set; }

        [StringLength(10)]
        public string MaLoaiHinh { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DOANDULICH> DOANDULICH { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GIATOUR> GIATOUR { get; set; }

        public virtual LOAIHINHDULICH LOAIHINHDULICH { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<THAMQUAN> THAMQUAN { get; set; }
    }
}
