using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace EntitiesDenemesi
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<TBLTEKBOYAADIMSB> TBLTEKBOYAADIMSB { get; set; }
        public virtual DbSet<TBLTEKBOYAPROSESHR> TBLTEKBOYAPROSESHR { get; set; }
        public virtual DbSet<TBLTEKBOYAPROSESSB> TBLTEKBOYAPROSESSB { get; set; }
        public virtual DbSet<ZZ_TBLTEKKIMRECETEHR> ZZ_TBLTEKKIMRECETEHR { get; set; }
        public virtual DbSet<ZZ_TBLTEKKIMRECETESB> ZZ_TBLTEKKIMRECETESB { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TBLTEKBOYAADIMSB>()
                .Property(e => e.REC_USERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<TBLTEKBOYAADIMSB>()
                .Property(e => e.REC_UPUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<TBLTEKBOYAADIMSB>()
                .Property(e => e.REC_CHANGED)
                .IsUnicode(false);

            modelBuilder.Entity<TBLTEKBOYAADIMSB>()
                .Property(e => e.REC_LOCKED)
                .IsUnicode(false);

            modelBuilder.Entity<TBLTEKBOYAADIMSB>()
                .Property(e => e.REC_VERSION)
                .IsUnicode(false);

            modelBuilder.Entity<TBLTEKBOYAADIMSB>()
                .Property(e => e.ISLEM_KODU)
                .IsUnicode(false);

            modelBuilder.Entity<TBLTEKBOYAADIMSB>()
                .Property(e => e.ISLEM_ADI)
                .IsUnicode(false);

            modelBuilder.Entity<TBLTEKBOYAADIMSB>()
                .Property(e => e.GRUP)
                .IsUnicode(false);

            modelBuilder.Entity<TBLTEKBOYAADIMSB>()
                .Property(e => e.MAKINE_KODU)
                .IsUnicode(false);

            modelBuilder.Entity<TBLTEKBOYAADIMSB>()
                .Property(e => e.ISI)
                .HasPrecision(28, 8);

            modelBuilder.Entity<TBLTEKBOYAADIMSB>()
                .Property(e => e.BASLAMA)
                .IsUnicode(false);

            modelBuilder.Entity<TBLTEKBOYAADIMSB>()
                .Property(e => e.CALISMA)
                .IsUnicode(false);

            modelBuilder.Entity<TBLTEKBOYAADIMSB>()
                .Property(e => e.BITIS)
                .IsUnicode(false);

            modelBuilder.Entity<TBLTEKBOYAADIMSB>()
                .Property(e => e.TUR)
                .IsUnicode(false);

            modelBuilder.Entity<TBLTEKBOYAADIMSB>()
                .Property(e => e.S_FLT)
                .IsUnicode(false);

            modelBuilder.Entity<TBLTEKBOYAADIMSB>()
                .Property(e => e.N_FOR)
                .IsUnicode(false);

            modelBuilder.Entity<TBLTEKBOYAADIMSB>()
                .Property(e => e.D_FOR)
                .IsUnicode(false);

            modelBuilder.Entity<TBLTEKBOYAADIMSB>()
                .Property(e => e.KAPASITE)
                .IsUnicode(false);

            modelBuilder.Entity<TBLTEKBOYAADIMSB>()
                .Property(e => e.KIMYEVI_RECETE_KODU)
                .IsUnicode(false);

            modelBuilder.Entity<TBLTEKBOYAADIMSB>()
                .Property(e => e.RECETE_KODU)
                .IsUnicode(false);

            modelBuilder.Entity<TBLTEKBOYAADIMSB>()
                .Property(e => e.FIKSE_APRE)
                .IsUnicode(false);

            modelBuilder.Entity<TBLTEKBOYAADIMSB>()
                .Property(e => e.PLAN_VARMI)
                .IsUnicode(false);

            modelBuilder.Entity<TBLTEKBOYAADIMSB>()
                .Property(e => e.PROGRAM_NO)
                .IsUnicode(false);

            modelBuilder.Entity<TBLTEKBOYAPROSESHR>()
                .Property(e => e.REC_USERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<TBLTEKBOYAPROSESHR>()
                .Property(e => e.REC_UPUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<TBLTEKBOYAPROSESHR>()
                .Property(e => e.REC_CHANGED)
                .IsUnicode(false);

            modelBuilder.Entity<TBLTEKBOYAPROSESHR>()
                .Property(e => e.REC_LOCKED)
                .IsUnicode(false);

            modelBuilder.Entity<TBLTEKBOYAPROSESHR>()
                .Property(e => e.REC_VERSION)
                .IsUnicode(false);

            modelBuilder.Entity<TBLTEKBOYAPROSESHR>()
                .Property(e => e.PROSES_NO)
                .IsUnicode(false);

            modelBuilder.Entity<TBLTEKBOYAPROSESHR>()
                .Property(e => e.ISLEM_KODU)
                .IsUnicode(false);

            modelBuilder.Entity<TBLTEKBOYAPROSESHR>()
                .Property(e => e.MAKINE_KODU)
                .IsUnicode(false);

            modelBuilder.Entity<TBLTEKBOYAPROSESHR>()
                .Property(e => e.GRP)
                .IsUnicode(false);

            modelBuilder.Entity<TBLTEKBOYAPROSESHR>()
                .Property(e => e.ACIKLAMA_HR)
                .IsUnicode(false);

            modelBuilder.Entity<TBLTEKBOYAPROSESHR>()
                .Property(e => e.ISI)
                .HasPrecision(28, 8);

            modelBuilder.Entity<TBLTEKBOYAPROSESHR>()
                .Property(e => e.BASLAMA)
                .IsUnicode(false);

            modelBuilder.Entity<TBLTEKBOYAPROSESHR>()
                .Property(e => e.CALISMA)
                .IsUnicode(false);

            modelBuilder.Entity<TBLTEKBOYAPROSESHR>()
                .Property(e => e.BITIS)
                .IsUnicode(false);

            modelBuilder.Entity<TBLTEKBOYAPROSESHR>()
                .Property(e => e.TUR)
                .IsUnicode(false);

            modelBuilder.Entity<TBLTEKBOYAPROSESHR>()
                .Property(e => e.S_FLT)
                .IsUnicode(false);

            modelBuilder.Entity<TBLTEKBOYAPROSESHR>()
                .Property(e => e.N_FOR)
                .IsUnicode(false);

            modelBuilder.Entity<TBLTEKBOYAPROSESHR>()
                .Property(e => e.D_FOR)
                .IsUnicode(false);

            modelBuilder.Entity<TBLTEKBOYAPROSESHR>()
                .Property(e => e.KAPASITE)
                .IsUnicode(false);

            modelBuilder.Entity<TBLTEKBOYAPROSESHR>()
                .Property(e => e.KAPASITE_BIRIMI)
                .IsUnicode(false);

            modelBuilder.Entity<TBLTEKBOYAPROSESHR>()
                .Property(e => e.BOYA)
                .IsUnicode(false);

            modelBuilder.Entity<TBLTEKBOYAPROSESHR>()
                .Property(e => e.KIMYEVI_RECETE_KODU)
                .IsUnicode(false);

            modelBuilder.Entity<TBLTEKBOYAPROSESSB>()
                .Property(e => e.REC_USERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<TBLTEKBOYAPROSESSB>()
                .Property(e => e.REC_UPUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<TBLTEKBOYAPROSESSB>()
                .Property(e => e.REC_CHANGED)
                .IsUnicode(false);

            modelBuilder.Entity<TBLTEKBOYAPROSESSB>()
                .Property(e => e.REC_LOCKED)
                .IsUnicode(false);

            modelBuilder.Entity<TBLTEKBOYAPROSESSB>()
                .Property(e => e.REC_VERSION)
                .IsUnicode(false);

            modelBuilder.Entity<TBLTEKBOYAPROSESSB>()
                .Property(e => e.PROSES_NO)
                .IsUnicode(false);

            modelBuilder.Entity<TBLTEKBOYAPROSESSB>()
                .Property(e => e.PROSES_ADI)
                .IsUnicode(false);

            modelBuilder.Entity<TBLTEKBOYAPROSESSB>()
                .Property(e => e.F_ISLEM)
                .IsUnicode(false);

            modelBuilder.Entity<TBLTEKBOYAPROSESSB>()
                .Property(e => e.DURUM)
                .IsUnicode(false);

            modelBuilder.Entity<TBLTEKBOYAPROSESSB>()
                .Property(e => e.PRS_TURU)
                .IsUnicode(false);

            modelBuilder.Entity<TBLTEKBOYAPROSESSB>()
                .Property(e => e.ACIKLAMA)
                .IsUnicode(false);

            modelBuilder.Entity<TBLTEKBOYAPROSESSB>()
                .HasMany(e => e.TBLTEKBOYAPROSESHR)
                .WithRequired(e => e.TBLTEKBOYAPROSESSB)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ZZ_TBLTEKKIMRECETEHR>()
                .Property(e => e.REC_USERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<ZZ_TBLTEKKIMRECETEHR>()
                .Property(e => e.REC_UPUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<ZZ_TBLTEKKIMRECETEHR>()
                .Property(e => e.REC_CHANGED)
                .IsUnicode(false);

            modelBuilder.Entity<ZZ_TBLTEKKIMRECETEHR>()
                .Property(e => e.REC_LOCKED)
                .IsUnicode(false);

            modelBuilder.Entity<ZZ_TBLTEKKIMRECETEHR>()
                .Property(e => e.RECETE_KODU)
                .IsUnicode(false);

            modelBuilder.Entity<ZZ_TBLTEKKIMRECETEHR>()
                .Property(e => e.KIMYA_KODU)
                .IsUnicode(false);

            modelBuilder.Entity<ZZ_TBLTEKKIMRECETEHR>()
                .Property(e => e.KIMYA_ADI)
                .IsUnicode(false);

            modelBuilder.Entity<ZZ_TBLTEKKIMRECETEHR>()
                .Property(e => e.GRAM_YUZDE)
                .HasPrecision(28, 8);

            modelBuilder.Entity<ZZ_TBLTEKKIMRECETEHR>()
                .Property(e => e.HESAPLAMA)
                .IsUnicode(false);

            modelBuilder.Entity<ZZ_TBLTEKKIMRECETEHR>()
                .Property(e => e.CARPAN)
                .HasPrecision(28, 8);

            modelBuilder.Entity<ZZ_TBLTEKKIMRECETEHR>()
                .Property(e => e.OTO_MAN)
                .IsUnicode(false);

            modelBuilder.Entity<ZZ_TBLTEKKIMRECETESB>()
                .Property(e => e.REC_USERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<ZZ_TBLTEKKIMRECETESB>()
                .Property(e => e.REC_UPUSERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<ZZ_TBLTEKKIMRECETESB>()
                .Property(e => e.REC_CHANGED)
                .IsUnicode(false);

            modelBuilder.Entity<ZZ_TBLTEKKIMRECETESB>()
                .Property(e => e.REC_LOCKED)
                .IsUnicode(false);

            modelBuilder.Entity<ZZ_TBLTEKKIMRECETESB>()
                .Property(e => e.RECETE_KODU)
                .IsUnicode(false);

            modelBuilder.Entity<ZZ_TBLTEKKIMRECETESB>()
                .Property(e => e.RECETE_ADI)
                .IsUnicode(false);

            modelBuilder.Entity<ZZ_TBLTEKKIMRECETESB>()
                .Property(e => e.KUMAS)
                .IsUnicode(false);

            modelBuilder.Entity<ZZ_TBLTEKKIMRECETESB>()
                .Property(e => e.FIRMA)
                .IsUnicode(false);

            modelBuilder.Entity<ZZ_TBLTEKKIMRECETESB>()
                .Property(e => e.GRUP)
                .IsUnicode(false);

            modelBuilder.Entity<ZZ_TBLTEKKIMRECETESB>()
                .Property(e => e.TUR)
                .IsUnicode(false);

            modelBuilder.Entity<ZZ_TBLTEKKIMRECETESB>()
                .Property(e => e.ACIKLAMA)
                .IsUnicode(false);
        }
    }
}
