namespace QuanLyTourWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DIADIEM")]
    public partial class DIADIEM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIADIEM()
        {
            THAMQUAN = new HashSet<THAMQUAN>();
        }

        [Key]
        [StringLength(10)]
        public string MaDiaDiem { get; set; }

        [StringLength(20)]
        public string TenDiaDiem { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<THAMQUAN> THAMQUAN { get; set; }
    }
}
