namespace EntitiesDenemesi
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TBLTEKBOYAADIMSB")]
    public partial class TBLTEKBOYAADIMSB
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
        [StringLength(50)]
        public string ISLEM_KODU { get; set; }

        [Required]
        [StringLength(100)]
        public string ISLEM_ADI { get; set; }

        [StringLength(50)]
        public string GRUP { get; set; }

        [StringLength(50)]
        public string MAKINE_KODU { get; set; }

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

        [StringLength(50)]
        public string KIMYEVI_RECETE_KODU { get; set; }

        [StringLength(50)]
        public string RECETE_KODU { get; set; }

        [StringLength(20)]
        public string FIKSE_APRE { get; set; }

        [StringLength(20)]
        public string PLAN_VARMI { get; set; }

        [StringLength(50)]
        public string PROGRAM_NO { get; set; }

        //aydin//
    }
}
