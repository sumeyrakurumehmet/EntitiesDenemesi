namespace EntitiesDenemesi
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ZZ_TBLTEKKIMRECETESB
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int REC_NO { get; set; }

        public DateTime? REC_DATE { get; set; }

        [StringLength(50)]
        public string REC_USERNAME { get; set; }

        public int? REC_USERID { get; set; }

        public DateTime? REC_UPDATE { get; set; }

        [StringLength(50)]
        public string REC_UPUSERNAME { get; set; }

        public int? REC_UPUSERID { get; set; }

        [StringLength(1)]
        public string REC_CHANGED { get; set; }

        [StringLength(1)]
        public string REC_LOCKED { get; set; }

        [Key]
        [StringLength(50)]
        public string RECETE_KODU { get; set; }

        [StringLength(100)]
        public string RECETE_ADI { get; set; }

        [StringLength(100)]
        public string KUMAS { get; set; }

        public int? LAB_NO { get; set; }

        [StringLength(100)]
        public string FIRMA { get; set; }

        public DateTime? TARIH { get; set; }

        [StringLength(100)]
        public string GRUP { get; set; }

        [StringLength(50)]
        public string TUR { get; set; }

        [StringLength(200)]
        public string ACIKLAMA { get; set; }
    }
}
