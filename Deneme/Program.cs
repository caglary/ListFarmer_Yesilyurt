using Deneme.Business;
using Deneme.Database.Context;
using Deneme.Database.DAL;
using Entity;
using Entity._2020;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
namespace Deneme
{
    class Program
    {
        static void Main(string[] args)
        {
            //IsletmeKaydet();
            //DilekceKaydet();
            //PersonelIslemleri();
            //            basadon:
            //            try
            //            {
            //DilekceKaydetxxx();
            //            }
            //            catch (Exception)
            //            {

            //                goto basadon;
            //            }

            //using (YesilyurtDbContext context = new YesilyurtDbContext())
            //{
            //    if (!context.Database.Exists())
            //    {
            //        context.Database.Create();

            //    }
            //}
            //Console.WriteLine("bitti..");
            try
            {
               var kullanici= HelpClass.Kullanici.KullaniciBilgisiGetir();
                Console.WriteLine($"Kullanici Adi:{kullanici.KullaniciAdi}\nParola:{kullanici.Parola}");

            }
            catch (Exception exception)
            {

                Console.WriteLine(exception.Message);
            }
            Console.Read();

        }

        //private static void DilekceKaydetxxx()
        //{
        //    //Database içerisinden çiftçi listesi alıyoruz...
        //    var cksListesi = CksListe2020();
        //    //selenium katmanına geçiş için instance alıyoruz...
        //    Selenium selenium = new Selenium();
        //    //dilekce işlemleri için dilekcebll katmanının instance alıyoruz.
        //    DilekceBll dilekceBll = new DilekceBll();
        //    //selenium browser açıyoruz..
        //    selenium.OpenBrowser();
        //    //Tbs sayfasını açıyoruz...
        //    selenium.TbsOpen();
        //    var dilekceler = dilekceBll.GetAll();
        //    //foreach (var item in cksListesi)
        //    //{
        //    //    var sonuc = from I in dilekceler
        //    //                where I.TcNumarasi == item.TcNumarasi
        //    //                select I;
        //    //    if (sonuc.Count() == 0)
        //    //    {
        //    //        selenium.GercekKisiKayitIslemleri(item.TcNumarasi);
        //    //        basadon:
        //    //         var dilekceleBilgileri = selenium.DilekceBilgileriGetir();
        //    //        if (dilekceleBilgileri == null) goto basadon;
        //    //        if (dilekceleBilgileri.Count != 0 )
        //    //        {
        //    //            foreach (var dilekce in dilekceleBilgileri)
        //    //            {
        //    //                dilekce.TcNumarasi = item.TcNumarasi;

        //    //                try
        //    //                {
        //    //                    // ulaşılan tc nin aynı yıl için dilekce kaydı var ise ekleme işlemi yapmasın..
        //    //                    var gelenDilekceBilgileri = dilekceBll.GetAll(dilekce);
        //    //                    var sonuc2 = from I in gelenDilekceBilgileri
        //    //                                 where I.UretimYili == dilekce.UretimYili
        //    //                                 select I;
        //    //                    if (sonuc2.Count() == 0)
        //    //                    {
        //    //                        dilekceBll.Add(dilekce);
        //    //                    }
        //    //                    else
        //    //                    {
        //    //                        var x = sonuc2.ToList();
        //    //                        dilekceBll.Update(x[0]);

        //    //                    }






        //    //                }
        //    //                catch (Exception exception)
        //    //                {
        //    //                    Console.WriteLine(exception.Message);

        //    //                }
        //    //            }
        //    //            Console.WriteLine($"{item.DosyaNo } {item.AdiSoyadi } işlem yapıldı.");
        //    //        }

        //    //        Console.WriteLine("Bitti...");
        //    //        selenium.CloseBrowser();

        //    //    }
        //    //}
        //}

        //private static void PersonelIslemleri()
        //{
        //    HelpClass.HardDrive hd = new HelpClass.HardDrive();
        //    var harddrive = hd.GetHDDInformation();

        //    string Kullanici = string.Empty;
        //    string ssdSerialNo = "BAC7078C135300234419";
        //    foreach (var hardDrive in harddrive)
        //    {
        //        if (hardDrive.SerialNo == ssdSerialNo) { Kullanici = "Çağlar"; }
        //    }

        //    Console.WriteLine(Kullanici);
        //    Console.Read();
        //}

        //private static void DilekceKaydet()
        //{
        //    //Database içerisinden çiftçi listesi alıyoruz...
        //    var cksListesi = CksListe2020();
        //    //selenium katmanına geçiş için instance alıyoruz...
        //    Selenium selenium = new Selenium();
        //    //dilekce işlemleri için dilekcebll katmanının instance alıyoruz.
        //    DilekceBll dilekceBll = new DilekceBll();
        //    //selenium browser açıyoruz..
        //    selenium.OpenBrowser();
        //    //Tbs sayfasını açıyoruz...
        //    selenium.TbsOpen();
        //    int nerdenDevamEdelim = 0;
        //devam:



        //    //try
        //    //{


        //    //    for (int i = nerdenDevamEdelim; i < cksListesi.Count(); i++)
        //    //    {
        //    //        nerdenDevamEdelim += 1;
        //    //        selenium.GercekKisiKayitIslemleri(cksListesi[i].TcNumarasi);

        //    //        var dilekceler = selenium.DilekceBilgileriGetir();

        //    //        // Herhangi bir dilekçe bilgisine ulaşılır ise...
        //    //        if (dilekceler.Count != 0 && dilekceler != null)
        //    //        {
        //    //            foreach (var dilekce in dilekceler)
        //    //            {
        //    //                dilekce.TcNumarasi = cksListesi[i].TcNumarasi;

        //    //                try
        //    //                {
        //    //                    // ulaşılan tc nin aynı yıl için dilekce kaydı var ise ekleme işlemi yapmasın..
        //    //                    var gelenDilekceBilgileri = dilekceBll.GetAll(dilekce);
        //    //                    var sonuc = from I in gelenDilekceBilgileri
        //    //                                where I.UretimYili == dilekce.UretimYili
        //    //                                select I;
        //    //                    if (sonuc.Count() == 0)
        //    //                    {
        //    //                        dilekceBll.Add(dilekce);
        //    //                    }
        //    //                    else
        //    //                    {
        //    //                        var x = sonuc.ToList();
        //    //                        dilekceBll.Update(x[0]);

        //    //                    }






        //    //                }
        //    //                catch (Exception exception)
        //    //                {
        //    //                    Console.WriteLine(exception.Message);

        //    //                }
        //    //            }
        //    //            Console.WriteLine($"{cksListesi[i].DosyaNo } {cksListesi[i].AdiSoyadi } işlem yapıldı.");
        //    //        }
        //    //    }
        //    //}
        //    //catch (Exception exception)
        //    //{

        //    //    Console.WriteLine(exception.Message);
        //    //    goto devam;
        //    //}

        //    Console.WriteLine("Bitti...");
        //    selenium.CloseBrowser();
        //}

        //private static List<CKS2020> CksListe2020()
        //{
        //    Cks2020Bll bll = new Cks2020Bll();
        //    return bll.GetAll();
        //}
        //private static void IsletmeKaydet()
        //{
        //    //#region Parsel Listesi
        //    string connectionString = "Data Source = M601102-0043; Initial Catalog = Yesilyurt; Integrated Security = True;";
        //    SqlConnection sqlConnnection = new SqlConnection(connectionString);
        //    //string sqlQuery = "select * from YesilyurtParsel";
        //    //SqlCommand sqlCommand = new SqlCommand(sqlQuery, sqlConnnection);
        //    //List<Entity.Parsel> Parseller = new List<Parsel>();
        //    //sqlConnnection.Open();
        //    //SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
        //    //while (sqlDataReader.Read())
        //    //{
        //    //    Parsel parselInfo = new Parsel();
        //    //    parselInfo.Id = sqlDataReader.GetInt32(0);
        //    //    parselInfo.IsletmeAdi = sqlDataReader.GetString(1);
        //    //    parselInfo.TcNo = sqlDataReader.GetString(2);
        //    //    parselInfo.Il = sqlDataReader.GetString(3);
        //    //    parselInfo.Ilce = sqlDataReader.GetString(4);
        //    //    parselInfo.Koy = sqlDataReader.GetString(5);
        //    //    parselInfo.Ada = sqlDataReader.GetString(6);
        //    //    parselInfo.Parsel = sqlDataReader.GetString(7);
        //    //    parselInfo.KullanilanAlan = sqlDataReader.GetDecimal(8);
        //    //    parselInfo.ParselAlani = sqlDataReader.GetDecimal(9);
        //    //    parselInfo.TarimsalNo = sqlDataReader.GetString(10);
        //    //    parselInfo.Urun = sqlDataReader.GetString(11);
        //    //    parselInfo.TarimSekli = sqlDataReader.GetString(12);
        //    //    parselInfo.EkiliAlan = sqlDataReader.GetDecimal(13);
        //    //    parselInfo.EkimTarihi = sqlDataReader.GetDateTime(14);
        //    //    parselInfo.HasatTarihi = sqlDataReader.GetDateTime(15);
        //    //    Parseller.Add(parselInfo);
        //    //}
        //    //sqlConnnection.Close();
        //    //#endregion
        //    #region TC Numaraları
        //    List<string> TcNumaralari = new List<string>();
        //    string sqlQueryTcNumaralari = "SELECT tcNo FROM[Yesilyurt].[dbo].[Parsel Bilgileri] group by tcNo";
        //    SqlCommand sqlCommandTcNumaralari = new SqlCommand(sqlQueryTcNumaralari, sqlConnnection);
        //    sqlConnnection.Open();
        //    var sqlDataReader = sqlCommandTcNumaralari.ExecuteReader();
        //    while (sqlDataReader.Read())
        //    {
        //        string tcNo = sqlDataReader.GetString(0);
        //        TcNumaralari.Add(tcNo);
        //    }
        //    sqlConnnection.Close();
        //    #endregion
        //    Parseller2019Dal parselDAL = new Parseller2019Dal();
        //    CiftcilerDal isletmeDAL = new CiftcilerDal();
        //    Selenium selenium = new Selenium();
        //    selenium.TbsOpen();
        //    foreach (var item in TcNumaralari)
        //    {
        //        //gelen tc nin varlığı sorgulanıyor...
        //        var result = isletmeDAL.GetAll().Where(I => I.TcKimlikNo == item).FirstOrDefault();
        //        if (result == null)
        //        {
        //            try
        //            {
        //                //tc numrası gönderiliyor...
        //                selenium.GercekKisiKayitIslemleri(item);
        //                //işletme bilgileri alınıyor...
        //                Ciftci isletmeBilgileri = selenium.IsletmeBilgi();
        //                isletmeBilgileri.TcKimlikNo = item;
        //                //işletme bilgileri kayıt altına alınıyor...
        //                isletmeDAL.Add(isletmeBilgileri);
        //                Console.WriteLine($"{isletmeBilgileri.TcKimlikNo } {isletmeBilgileri.Name } {isletmeBilgileri.Soyad } {isletmeBilgileri.KoyMahalle } işlendi... ");
        //            }
        //            catch (Exception)
        //            {
        //            }
        //        }
        //    }
        //    //List<ParselBilgi> parselBilgileri= parselBilgiDal.GetAll();
        //    Console.WriteLine("Bitti...");
        //    Console.Read();
        //}
    }
}
