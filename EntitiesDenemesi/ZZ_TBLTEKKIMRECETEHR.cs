namespace EntitiesDenemesi
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ZZ_TBLTEKKIMRECETEHR
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
        [Column(Order = 0)]
        [StringLength(50)]
        public string RECETE_KODU { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SIRA_NO { get; set; }

        [StringLength(50)]
        public string KIMYA_KODU { get; set; }

        [StringLength(100)]
        public string KIMYA_ADI { get; set; }

        public decimal? GRAM_YUZDE { get; set; }

        [StringLength(50)]
        public string HESAPLAMA { get; set; }

        public decimal? CARPAN { get; set; }

        public int? GRUP_HR { get; set; }

        [StringLength(50)]
        public string OTO_MAN { get; set; }
    }
}
