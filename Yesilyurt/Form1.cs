using Deneme;
using Deneme.Business;
using Entity;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Yesilyurt._2020;
using Yesilyurt._2021;

namespace Yesilyurt
{
    public partial class Form1 : Form
    {
        CiftcilerBll isletmeBll;
        Selenium _selenium;
        List<Ciftci> Liste = null;
        public Form1()
        {
            InitializeComponent();
            isletmeBll = new CiftcilerBll();
            _selenium = new Selenium();
           
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridViewListe.DataSource = isletmeBll.GetAll();
            dataGridViewListe.Columns["Id"].Visible = false;
            lblToplamKisi.Text = $"Çiftçi listesi, toplam {dataGridViewListe.RowCount} adet çiftçi kayıtlıdır.";
        }
        
        private void btnTbs_Click(object sender, EventArgs e)
        {
            try
            {
                var result = isletmeBll.IsletmeBilgiGetir(txtTcNumarasi.Text);
                result.TcKimlikNo = txtTcNumarasi.Text;
                DialogResult dr = HelpClass.MessageBoxOperation.MessageBoxQuestion($"{result.TcKimlikNo} {result.Ad} {result.Soyad} eklemek istiyor musunuz?");
                if (dr == DialogResult.Yes)
                {
                    isletmeBll.Add(result);
                    txtTcNumarasi.Text = "";
                    txtTcNumarasi.Text = result.TcKimlikNo;

                    TcSearch();

                }
            }
            catch (Exception exception)
            {
                HelpClass.MessageBoxOperation.MessageBoxError(exception.Message);
            }
            finally
            {
                _selenium.CloseBrowser();
            }
        }

        private void btnCKSListe_Click(object sender, EventArgs e)
        {
            Form _form = Application.OpenForms["Cks2020"];
            if (_form != null) //form açıksa 
            {
                _form.Focus();
            }
            else if (_form == null)
            {
                //form açık değilse 
                Cks2020 formCKS2020 = new Cks2020();
                formCKS2020.Show();
            }
        }
        private void dataGridViewListe_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string seciliTc = dataGridViewListe.CurrentRow.Cells["TcKimlikNo"].Value.ToString();
            var ciftci = isletmeBll.GetAll().Where(I => I.TcKimlikNo == seciliTc).FirstOrDefault();
            CiftciGuncelle formCiftciGuncelle = new CiftciGuncelle(ciftci);
            formCiftciGuncelle.ShowDialog();
        }
       
        private void btnSertifikaliTohum_Click(object sender, EventArgs e)
        {
            Form _form = Application.OpenForms["SertifikaliTohumForm"];
            if (_form != null) //form açıksa 
            {
                _form.Focus();
            }
            else if (_form == null)
            {
                //form açık değilse 
                SertifikaliTohum2020 sform = new SertifikaliTohum2020();
                sform.Show();
            }
        }
        private void btnListeler_Click(object sender, EventArgs e)
        {
            Form _form = Application.OpenForms["Excel"];
            if (_form != null) //form açıksa 
            {
                _form.Focus();
            }
            else if (_form == null)
            {
                //form açık değilse 
                Listeler sform = new Listeler();
                sform.Show();
            }
        }
        private void btnJsonBackup_Click(object sender, EventArgs e)
        {
            var liste = isletmeBll.GetAll();
            string jsonListe = JsonConvert.SerializeObject(liste);
            var path = $"{Directory.GetCurrentDirectory()}\\YedekJson";

            if (Directory.Exists(path))
            {
                // ilgili klasor var ise herhangi bir işlem yapmıyoruz. 
            }
            else
            {
                Directory.CreateDirectory(path);
            }

            DialogResult dialogResult = HelpClass.MessageBoxOperation.MessageBoxQuestion($"Veriler {path + "\\ciftciler.json"} adresine kaydedilecek. Devam etmek istiyor musunuz?");
            if (dialogResult == DialogResult.Yes) File.WriteAllText(path + "\\ciftciler.json", jsonListe);

        }
        private void btnJsonRestore_Click(object sender, EventArgs e)
        {
            string filePath = HelpClass.FileOperation.FilePath("Json Dosyası | *.json");
            string okunanListe = File.ReadAllText(filePath);

            var liste = JsonConvert.DeserializeObject<List<Entity.Ciftci>>(okunanListe);
            if (HelpClass.WhichComputer.ComputerName() == "Lenovo")
            {
                foreach (var item in liste)
                {
                    isletmeBll.Restore(item);
                }
                HelpClass.MessageBoxOperation.MessageBoxInformation("İşlem tamamlandı.");
                dataGridViewListe.DataSource = isletmeBll.GetAll();
                dataGridViewListe.Columns["Id"].Visible = false;
                lblToplamKisi.Text = $"Çiftçi listesi, toplam {dataGridViewListe.RowCount} adet çiftçi kayıtlıdır.";
            }
            else
            {
                HelpClass.MessageBoxOperation.MessageBoxInformation("Database içerisinde bu işlemi gerçekleştiremezsiniz.");
            }

        }
        private void btnCks2020Aktar_Click(object sender, EventArgs e)
        {
          
        }
        private void btnTcAra_Click(object sender, EventArgs e)
        {
            TcSearch();
        }

        private void TcSearch()
        {
            Liste = isletmeBll.GetAll();
            var textBoxText = txtTcNumarasi.Text.ToUpper(new CultureInfo("tr-TR", false));
            var result = from i in Liste
                         where i.TcKimlikNo.Contains(textBoxText)
                         select i;
            dataGridViewListe.DataSource = result.ToList();
        }

        private void btnIsimAra_Click(object sender, EventArgs e)
        {
            Liste = isletmeBll.GetAll();
            var textBoxText = txtSerachIsim.Text.ToUpper(new CultureInfo("tr-TR", false));
            var result = from i in Liste
                         where i.Ad.Contains(textBoxText)
                         select i;
            dataGridViewListe.DataSource = result.ToList();
        }
        private void btnCks2021Listele_Click(object sender, EventArgs e)
        {
            Form _form = Application.OpenForms["Cks2021Form"];
            if (_form != null) //form açıksa 
            {
                _form.Focus();
            }
            else if (_form == null)
            {
                //form açık değilse 
                Cks2021Form cks2021Form = new Cks2021Form();
                cks2021Form.Show();
            }
        }
        private void btnCks2021Aktar_Click(object sender, EventArgs e)
        {
            //Bu metot Liste içerisinden seçilen çiftçiyi ÇKS2021 listesinin içerisine kayıt yapıyor.

            string seciliTc = null;
            try
            {
                //tablo boş ise tc seçmeyecektir.
                try
                {
                    seciliTc = dataGridViewListe.CurrentRow.Cells["TcKimlikNo"].Value.ToString();
                }
                catch (Exception exception)
                {
                    throw new Exception("Tablodan herhangi bir veri seçilmedi");
                }
                //bir değer seçildiğinde işleme devam edilecek...
                if (seciliTc != null)
                {
                    var isletme = isletmeBll.GetAll().Where(I => I.TcKimlikNo == seciliTc).FirstOrDefault();
                    Cks2021AddForm cks2021AddForm = new Cks2021AddForm (isletme);
                    cks2021AddForm.ShowDialog();
                }
            }
            catch (Exception exception)
            {
                HelpClass.MessageBoxOperation.MessageBoxError(exception.Message);
            }
        }
    }
}
