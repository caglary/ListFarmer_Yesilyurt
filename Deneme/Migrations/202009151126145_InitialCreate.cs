
namespace Deneme.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Çiftçi Listesi",
                c => new
                    {
                        CiftciID = c.Int(name: "Ciftci ID", nullable: false, identity: true),
                        TcKimlikNo = c.String(),
                        Ad = c.String(),
                        Soyad = c.String(),
                        BabaAdi = c.String(),
                        AnneAdi = c.String(),
                        DogumTarihi = c.DateTime(nullable: false),
                        OlumTarihi = c.String(),
                        Cinsiyet = c.String(),
                        MedeniDurum = c.String(),
                        CepTelefon = c.String(),
                        EvTelefon = c.String(),
                        Email = c.String(),
                        Il = c.String(),
                        Ilce = c.String(),
                        KoyMahalle = c.String(),
                    })
                .PrimaryKey(t => t.CiftciID);
            
            CreateTable(
                "dbo.ÇKS 2020 Listesi",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DosyaNo = c.Int(nullable: false),
                        TcKimlikNo = c.String(),
                        AdSoyad = c.String(),
                        BabaAdi = c.String(),
                        KoyMahalle = c.String(),
                        CepTelefon = c.String(),
                        EvTelefon = c.String(),
                        KayitTarih = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Mazot Gubre Destek 2019",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SiraNo = c.Int(nullable: false),
                        Il = c.String(),
                        Ilce = c.String(),
                        MahalleKoy = c.String(),
                        IsletmeAdi = c.String(),
                        BabaAdi = c.String(),
                        DogumTarihi = c.DateTime(nullable: false),
                        TcKimlikNo = c.String(),
                        MazotAlani = c.Decimal(nullable: false, precision: 18, scale: 2),
                        MazotDesteklemeMiktari = c.Decimal(nullable: false, precision: 18, scale: 2),
                        GubreAlani = c.Decimal(nullable: false, precision: 18, scale: 2),
                        GubreDesteklemeMiktari = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ToplamDesteklemeMiktari = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Parsel Bilgileri 2019",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IsletmeAdi = c.String(),
                        TcNo = c.String(),
                        Il = c.String(),
                        Ilce = c.String(),
                        Koy = c.String(),
                        Ada = c.String(),
                        Parsel = c.String(),
                        KullanilanAlan = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ParselAlani = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TarimsalNo = c.String(),
                        Urun = c.String(),
                        TarimSekli = c.String(),
                        EkiliAlan = c.Decimal(nullable: false, precision: 18, scale: 2),
                        EkimTarihi = c.DateTime(nullable: false),
                        HasatTarihi = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Sertifikalı Tohum Başvuru 2020",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BasvuruYili = c.Int(nullable: false),
                        CksDosyaNo = c.Int(nullable: false),
                        SertifikaliTohumDosyaNo = c.Int(nullable: false),
                        TcNumarasi = c.String(),
                        AdiSoyadi = c.String(),
                        BabaAdi = c.String(),
                        Koy = c.String(),
                        MuracaatTarih = c.DateTime(nullable: false),
                        FaturaNo = c.String(),
                        FaturaTarihi = c.DateTime(nullable: false),
                        FirmaAdi = c.String(),
                        Urun = c.String(),
                        UrunCesidi = c.String(),
                        Miktari = c.Decimal(nullable: false, precision: 18, scale: 2),
                        BirimFiyati = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ToplamMaliyet = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Sertifikalı Tohum Başvuru 2020");
            DropTable("dbo.Parsel Bilgileri 2019");
            DropTable("dbo.Mazot Gubre Destek 2019");
            DropTable("dbo.ÇKS 2020 Listesi");
            DropTable("dbo.Çiftçi Listesi");
        }
    }
}
