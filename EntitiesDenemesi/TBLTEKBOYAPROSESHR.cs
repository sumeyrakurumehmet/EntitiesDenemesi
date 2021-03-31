namespace EntitiesDenemesi
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TBLTEKBOYAPROSESHR")]
    public partial class TBLTEKBOYAPROSESHR
    {
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
        [Column(Order = 0)]
        [StringLength(50)]
        public string PROSES_NO { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SIRA { get; set; }

        [StringLength(50)]
        public string ISLEM_KODU { get; set; }

        [StringLength(50)]
        public string MAKINE_KODU { get; set; }

        [StringLength(50)]
        public string GRP { get; set; }

        [StringLength(100)]
        public string ACIKLAMA_HR { get; set; }

        public decimal? ISI { get; set; }

        [StringLength(20)]
        public string BASLAMA { get; set; }

        [StringLength(20)]
        public string CALISMA { get; set; }

        [StringLength(20)]
        public string BITIS { get; set; }

        [StringLength(20)]
        public string TUR { get; set; }

        [StringLength(20)]
        public string S_FLT { get; set; }

        [StringLength(20)]
        public string N_FOR { get; set; }

        [StringLength(20)]
        public string D_FOR { get; set; }

        [StringLength(20)]
        public string KAPASITE { get; set; }

        [StringLength(20)]
        public string KAPASITE_BIRIMI { get; set; }

        [StringLength(20)]
        public string BOYA { get; set; }

        [StringLength(50)]
        public string KIMYEVI_RECETE_KODU { get; set; }

        public virtual TBLTEKBOYAPROSESSB TBLTEKBOYAPROSESSB { get; set; }
    }
}
