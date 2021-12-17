namespace QuanLyTourWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LOAIHINHDULICH")]
    public partial class LOAIHINHDULICH
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LOAIHINHDULICH()
        {
            TOURDULICH = new HashSet<TOURDULICH>();
        }

        [Key]
        [StringLength(10)]
        public string MaLoaiHinh { get; set; }

        [StringLength(20)]
        public string TenLoaiHinh { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TOURDULICH> TOURDULICH { get; set; }
    }
}
