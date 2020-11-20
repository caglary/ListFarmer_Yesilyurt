using Entity;
using Entity.HelpClass;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
namespace Deneme
{
    public class Selenium
    {

        static IWebElement button;
        static IWebDriver driver;
        private void Stop(int saniye)
        {
            System.Threading.Thread.Sleep(saniye * 1000);
        }
        public void OpenBrowser()
        {
            if (driver == null) driver = new ChromeDriver();
        }
        public void TbsOpen()
        {
            Kullanici kullanici = KullaniciBilgisi();
            OpenBrowser();
            driver.Url = "https://tbs.tarbil.gov.tr/Main/Login";
            Stop(2);
            driver.FindElement(By.Id("txttcNo")).SendKeys(kullanici.KullaniciAdi);
            driver.FindElement(By.Id("txtsifre")).SendKeys(kullanici.Parola);
            driver.FindElement(By.Id("btnLogin")).Click();
            Stop(2);
            //driver.Manage().Window.Maximize();
        }
        public void CloseBrowser()
        {
            if (driver != null)
            {
                driver.Quit();
                driver = null;
            }
        }
        public void GercekKisiKayitIslemleri(string tcNumarasi)
        {
            //driver.Navigate().Refresh();

            driver.Url = "http://tbsapp.tarbil.gov.tr/Modules/ACM/CKSList.aspx?CorporationType=1#person";
            Stop(2);
            try
            {
                string tcNoId = "ctl00_ctl00_bodyCPH_ContentPlaceHolder1_HoldingSearchControlUC_RadPanelBar1_i0_edtIdNo11";
                driver.FindElement(By.Id(tcNoId)).Click();
                //driver.FindElement(By.Id(tcNoId)).SendKeys("");
                for (int i = 0; i < 11; i++)
                {
                    driver.FindElement(By.Id(tcNoId)).SendKeys(Keys.Backspace);
                }

                driver.FindElement(By.Id(tcNoId)).SendKeys(tcNumarasi);

                string gercekKisiAraButonİd = "ctl00_ctl00_bodyCPH_ContentPlaceHolder1_HoldingSearchControlUC_RadPanelBar1_i0_btnSearch11";
                driver.FindElement(By.Id(gercekKisiAraButonİd)).Click();
                Stop(2);
                string detayButtonId = "ctl00_ctl00_bodyCPH_ContentPlaceHolder1_grdList_ctl00_ctl04_EditButton";
                driver.FindElement(By.Id(detayButtonId)).Click();
                Stop(2);
                //Mernis Kontrol...
                //string mernisKontrolId = "bodyCPH_ContentPlaceHolder1_HoldingDetailControl_btnMernis";
                //driver.FindElement(By.Id(mernisKontrolId)).Click();
            }
            catch (Exception exception)
            {
                driver.Navigate().Refresh();
                Console.WriteLine(exception.Message);
            }
        }
        public Ciftci IsletmeBilgi()
        {
            Stop(1);
            Ciftci isletmeBilgileri = new Ciftci();
            string nameId = "bodyCPH_ContentPlaceHolder1_HoldingDetailControl_edtNameCorporationType1";
            string soyadId = "bodyCPH_ContentPlaceHolder1_HoldingDetailControl_edtSurname";
            string babaAdiId = "bodyCPH_ContentPlaceHolder1_HoldingDetailControl_edtFatherName";
            string anneAdiId = "bodyCPH_ContentPlaceHolder1_HoldingDetailControl_edtMotherName";
            string dogumTarihiId = "bodyCPH_ContentPlaceHolder1_HoldingDetailControl_edtBirthdate";
            string olumTarihiId = "bodyCPH_ContentPlaceHolder1_HoldingDetailControl_lbledtDeathOrCloseDateCorporationType1";
            string cinsiyetId = "bodyCPH_ContentPlaceHolder1_HoldingDetailControl_txtGender";
            string medeniDurumId = "bodyCPH_ContentPlaceHolder1_HoldingDetailControl_txtMaritalStatus";
            string cepTelefonuId = "ctl00_ctl00_bodyCPH_ContentPlaceHolder1_HoldingDetailControl_edtMobilePhone";
            string evTelfonuId = "ctl00_ctl00_bodyCPH_ContentPlaceHolder1_HoldingDetailControl_edtPhone";
            string ilId = "ctl00_ctl00_bodyCPH_ContentPlaceHolder1_HoldingDetailControl_CityTownVillageControl_edtCityId_Input";
            string ilceId = "ctl00_ctl00_bodyCPH_ContentPlaceHolder1_HoldingDetailControl_CityTownVillageControl_edtTownId_Input";
            string koyMahalleId = "ctl00_ctl00_bodyCPH_ContentPlaceHolder1_HoldingDetailControl_CityTownVillageControl_edtVillageId_Input";
            string name = driver.FindElement(By.Id(nameId)).Text;
            string soyad = driver.FindElement(By.Id(soyadId)).Text;
            string babaAdi = driver.FindElement(By.Id(babaAdiId)).Text;
            string anneAdi = driver.FindElement(By.Id(anneAdiId)).Text;
            string dogumTarihi = driver.FindElement(By.Id(dogumTarihiId)).Text;
            try
            {
                string olumTarihi = driver.FindElement(By.Id(olumTarihiId)).Text;
                isletmeBilgileri.OlumTarihi = olumTarihi;
            }
            catch (Exception)
            {
                isletmeBilgileri.OlumTarihi = string.Empty;
            }
            string cinsiyet = driver.FindElement(By.Id(cinsiyetId)).Text;
            string medeniDurum = driver.FindElement(By.Id(medeniDurumId)).Text;
            string cepTelefonu = driver.FindElement(By.Id(cepTelefonuId)).GetAttribute("value");
            string evTelfonu = driver.FindElement(By.Id(evTelfonuId)).GetAttribute("value");
            string il = driver.FindElement(By.Id(ilId)).GetAttribute("value");
            string ilce = driver.FindElement(By.Id(ilceId)).GetAttribute("value");
            string koyMahalle = driver.FindElement(By.Id(koyMahalleId)).GetAttribute("value");
            isletmeBilgileri.Ad = name;
            isletmeBilgileri.Soyad = soyad;
            isletmeBilgileri.BabaAdi = babaAdi;
            isletmeBilgileri.AnneAdi = anneAdi;
            isletmeBilgileri.DogumTarihi = Convert.ToDateTime(dogumTarihi);
            isletmeBilgileri.Cinsiyet = cinsiyet;
            isletmeBilgileri.MedeniDurum = medeniDurum;
            isletmeBilgileri.CepTelefon = cepTelefonu;
            isletmeBilgileri.EvTelefon = evTelfonu;
            isletmeBilgileri.Il = il;
            isletmeBilgileri.Ilce = ilce;
            isletmeBilgileri.KoyMahalle = koyMahalle;
            return isletmeBilgileri;
        }
        public Ciftci IsletmeBilgiGetir(string TcNumarasi)
        {

            TbsOpen();
            GercekKisiKayitIslemleri(TcNumarasi);
            var isletmeBilgisi = IsletmeBilgi();
            isletmeBilgisi.TcKimlikNo = TcNumarasi;
            CloseBrowser();
            return isletmeBilgisi;
        }
        static Kullanici KullaniciBilgisi()
        {
            Kullanici kullanici = new Kullanici();
            kullanici = HelpClass.Kullanici.KullaniciBilgisiGetir();
            return kullanici;
        }

        #region CanceledMethod
        //public List<Dilekce> DilekceBilgileriGetir()
        //{
        //    ButonTıkla("Dilekçeler");
        //    Stop(3);
        //    try
        //    {

        //        string dilekceNumarasi;
        //        List<Dilekce> dilekceler = new List<Dilekce>();
        //        List<IWebElement> tablergRow = driver.FindElements(By.ClassName("rgRow")).ToList();
        //        List<IWebElement> tablergAltRow = driver.FindElements(By.ClassName("rgAltRow")).ToList();
        //        foreach (var item in tablergRow)
        //        {
        //            Dilekce dilekce = new Dilekce();
        //            List<IWebElement> tr = item.FindElements(By.TagName("td")).ToList();
        //            dilekceNumarasi = tr[1].Text;
        //            if (dilekceNumarasi != "" && item.Text != "")
        //            {
        //                dilekce.DilekceNumarasi = tr[1].Text == "" ? "": tr[1].Text;
        //                try
        //                {
        //                    dilekce.DilekceTarihi = tr[2].Text == "" ? DateTime.Now : Convert.ToDateTime(tr[2].Text);

        //                }
        //                catch (Exception)
        //                {
        //                    dilekce.DilekceTarihi = DateTime.Now;


        //                }
        //                try
        //                {
        //                    dilekce.DilekceKabulTarihi = tr[4].Text == "" ? DateTime.Now : Convert.ToDateTime(tr[4].Text);
        //                }
        //                catch (Exception)
        //                {

        //                    dilekce.DilekceKabulTarihi = DateTime.Now;
        //                }


        //                dilekce.UretimYili = tr[3].Text == "" ? "" : tr[3].Text;

        //                dilekce.IlAdi = tr[5].Text==""?"": tr[5].Text;
        //                dilekce.IlceAdi = tr[6].Text == "" ? "" : tr[6].Text;
        //                dilekce.Durum = tr[7].Text == "" ? "" : tr[7].Text;
        //                dilekceler.Add(dilekce);
        //            }
        //        }
        //        foreach (var item in tablergAltRow)
        //        {
        //            Dilekce dilekce = new Dilekce();
        //            List<IWebElement> tr = item.FindElements(By.TagName("td")).ToList();
        //            dilekceNumarasi = tr[1].Text;
        //            if (dilekceNumarasi != "" && item.Text != "")
        //            {
        //                dilekce.DilekceNumarasi = tr[1].Text == "" ? "" : tr[1].Text;
        //                try
        //                {
        //                    dilekce.DilekceTarihi = tr[2].Text == "" ? DateTime.Now : Convert.ToDateTime(tr[2].Text);

        //                }
        //                catch (Exception)
        //                {
        //                    dilekce.DilekceTarihi = DateTime.Now;


        //                }
        //                try
        //                {
        //                    dilekce.DilekceKabulTarihi = tr[4].Text == "" ? DateTime.Now : Convert.ToDateTime(tr[4].Text);
        //                }
        //                catch (Exception)
        //                {

        //                    dilekce.DilekceKabulTarihi = DateTime.Now;
        //                }


        //                dilekce.UretimYili = tr[3].Text == "" ? "" : tr[3].Text;

        //                dilekce.IlAdi = tr[5].Text == "" ? "" : tr[5].Text;
        //                dilekce.IlceAdi = tr[6].Text == "" ? "" : tr[6].Text;
        //                dilekce.Durum = tr[7].Text == "" ? "" : tr[7].Text;
        //                dilekceler.Add(dilekce);
        //            }
        //        }
        //        return dilekceler;
        //    }
        //    catch (Exception)
        //    {
        //        return null;
        //        //throw new Exception("dilekce bilgileri getirilemedi"); 
        //    }
        //}
        #endregion

        public void ButonTıkla(string hangiMenu)
        {
            int whichMenu = 12;
            string[] menuName = new string[whichMenu];
            for (int i = 1; i < whichMenu; i++)
            {
                try
                {
                    button = driver.FindElement(By.CssSelector("#ctl00_ctl00_bodyCPH_ContentPlaceHolder1_RadTabStrip1>div>ul>li:nth-child(" + i + ")>a>span>span>span"));
                    if (button.Displayed)
                    {
                        //Console.Write("element is found  ");
                        //Console.WriteLine(button.Text);
                        menuName[i] = button.Text;
                        if (menuName[i] == hangiMenu)
                            button.Click();
                    }
                }
                catch (Exception)
                {
                    //Console.WriteLine("element is NOT found");
                }
            }
        }

    }

}
