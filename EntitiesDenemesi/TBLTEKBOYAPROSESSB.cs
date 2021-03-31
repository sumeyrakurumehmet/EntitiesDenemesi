namespace EntitiesDenemesi
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TBLTEKBOYAPROSESSB")]
    public partial class TBLTEKBOYAPROSESSB
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBLTEKBOYAPROSESSB()
        {
            TBLTEKBOYAPROSESHR = new HashSet<TBLTEKBOYAPROSESHR>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int REC_NO { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? REC_DATE { get; set; }

        [StringLength(50)]
        public string REC_USERNAME { get; set; }

        public int? REC_USERID { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? REC_UPDATE { get; set; }

        [StringLength(50)]
        public string REC_UPUSERNAME { get; set; }

        public int? REC_UPUSERID { get; set; }

        [StringLength(1)]
        public string REC_CHANGED { get; set; }

        [StringLength(1)]
        public string REC_LOCKED { get; set; }

        [StringLength(50)]
        public string REC_VERSION { get; set; }

        [Key]
        [StringLength(50)]
        public string PROSES_NO { get; set; }

        [Required]
        [StringLength(100)]
        public string PROSES_ADI { get; set; }

        [StringLength(50)]
        public string F_ISLEM { get; set; }

        [StringLength(20)]
        public string DURUM { get; set; }

        [StringLength(20)]
        public string PRS_TURU { get; set; }

        [StringLength(100)]
        public string ACIKLAMA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLTEKBOYAPROSESHR> TBLTEKBOYAPROSESHR { get; set; }
    }
}
