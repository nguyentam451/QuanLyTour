namespace QuanLyTourWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LOAICHIPHI")]
    public partial class LOAICHIPHI
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LOAICHIPHI()
        {
            CHIPHI = new HashSet<CHIPHI>();
        }

        [Key]
        [StringLength(10)]
        public string MaLoaiChiPhi { get; set; }

        [StringLength(20)]
        public string TenLoaiChiPhi { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHIPHI> CHIPHI { get; set; }
    }
}
