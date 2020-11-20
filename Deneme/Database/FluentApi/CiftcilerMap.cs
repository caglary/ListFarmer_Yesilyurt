using Entity;
using System.Data.Entity.ModelConfiguration;

namespace Deneme.Database.FluentApi
{
    public class CiftcilerMap:EntityTypeConfiguration<Ciftci>
    {
        public CiftcilerMap()
        {
            this.ToTable("Çiftçi Listesi");

            this.HasKey(I => I.Id);
            
            this.Property(I => I.Id).HasColumnOrder(0).HasColumnName("Ciftci ID");

            this.Property(I => I.TcKimlikNo).IsRequired().HasColumnOrder(1);
            this.Property(I => I.Ad).IsRequired().HasColumnOrder(2);
            this.Property(I => I.Soyad).IsRequired().HasColumnOrder(3);
            this.Property(I => I.BabaAdi).IsRequired().HasColumnOrder(4);
            this.Property(I => I.AnneAdi).IsRequired().HasColumnOrder(5);
            this.Property(I => I.DogumTarihi).HasColumnOrder(6);
            this.Property(I => I.OlumTarihi).HasColumnOrder(7);
            this.Property(I => I.Cinsiyet).HasColumnOrder(8);
            this.Property(I => I.MedeniDurum).HasColumnOrder(9);
            this.Property(I => I.CepTelefon).HasColumnOrder(10);
            this.Property(I => I.EvTelefon).HasColumnOrder(11);
            this.Property(I => I.Email).HasColumnOrder(12);
            this.Property(I => I.Il).IsRequired().HasColumnOrder(13);
            this.Property(I => I.Ilce).IsRequired().HasColumnOrder(14);
            this.Property(I => I.KoyMahalle).IsRequired().HasColumnOrder(15);







        }
    }
}
