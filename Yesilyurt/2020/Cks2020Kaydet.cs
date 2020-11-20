using Deneme.Business._2020;
using Entity;
using Entity._2020;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
namespace Yesilyurt._2020
{
    public partial class Cks2020Kaydet : Form
    {
        Ciftci isletme;
        Cks2020Bll bll;
        public Cks2020Kaydet(Ciftci isletmeInfo)
        {
            InitializeComponent();
            isletme = isletmeInfo;
            bll = new Cks2020Bll();
        }
     
        private void Cks2020Kaydet_Load(object sender, EventArgs e)
        {
            txtDosyaNo.Text = CreateDosyaNo();
            txtkoy.Text = isletme.KoyMahalle;
            txtTcNumarasi.Text = isletme.TcKimlikNo;
            txtBabaAdi.Text = isletme.BabaAdi;
            txtAdiSoyadi.Text = isletme.Ad + " " + isletme.Soyad;
            txtCepTelefon.Text = isletme.CepTelefon;
            txtEvTelefon.Text = isletme.EvTelefon;
            txtTarih.Text = DateTime.Now.ToShortDateString();
            txtTarih.Focus();
            
            
        }
        private string CreateDosyaNo()
        {
            
            //Kayıt yapılacak kişiye dosya numarası verilecek.
            //enson kaydı okuyacak ve son kaydın dosya numarasını 1 arttırıp yeni kişiye verecek.
            var gelenKayit = bll.GetAll().OrderByDescending(I => I.DosyaNo).FirstOrDefault();
            var dosyaNo = gelenKayit.DosyaNo + 1;
            return dosyaNo.ToString();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                CKS2020 CKS = new CKS2020();
                CKS.AdSoyad = txtAdiSoyadi.Text;
                CKS.BabaAdi = txtBabaAdi.Text;
                CKS.KoyMahalle = txtkoy.Text;
                CKS.TcKimlikNo = txtTcNumarasi.Text;
                CKS.CepTelefon = txtCepTelefon.Text;
                CKS.EvTelefon = txtEvTelefon.Text;
                CKS.DosyaNo = Convert.ToInt32( txtDosyaNo.Text);
                if (txtTarih.Text == DateTime.Now.ToShortDateString())
                {
                    CKS.KayitTarih = Convert.ToDateTime(txtTarih.Text);

                    DialogResult dr = HelpClass.MessageBoxOperation.MessageBoxQuestion("Tarih kısmında güncelleme yapmadınız. Devam etmek istiyor musunuz?");
                    if (dr == DialogResult.Yes)
                    {
                        //ekleme işlemini yapacak...
                        bll.Add(CKS);
                        //daha sonra çks listesi açık değilse açacak..
                        Form cks2020Form = Application.OpenForms["Cks2020"];
                        if (cks2020Form == null)
                        {
                            //form açılırken güncel listeyi sana gösterecek..
                            Cks2020 yeniCks2020formAc = new Cks2020();
                            yeniCks2020formAc.Show();
                        }
                        else
                        {
                            //eğer açıksa liste içinde güncellenmiş listeyi sana gösterecek...
                            DataGridView dgw = (DataGridView)cks2020Form.Controls["dataGridViewListe"];
                            dgw.DataSource = bll.GetAll().OrderByDescending(I => I.DosyaNo).ToList();
                        }
                    }
                }
                else
                {
                    CKS.KayitTarih = Convert.ToDateTime(txtTarih.Text);
                    //ekleme işlemini yapacak...
                    bll.Add(CKS);
                    //daha sonra çks listesi açık değilse açacak..
                    Form cks2020Form = Application.OpenForms["Cks2020"];
                    if (cks2020Form == null)
                    {
                        //form açılırken güncel listeyi sana gösterecek..
                        Cks2020 yeniCks2020formAc = new Cks2020();
                        yeniCks2020formAc.Show();
                    }
                    else
                    {
                        //eğer açıksa liste içinde güncellenmiş listeyi sana gösterecek...
                        DataGridView dgw = (DataGridView)cks2020Form.Controls["dataGridViewListe"];
                        dgw.DataSource = bll.GetAll().OrderByDescending(I => I.DosyaNo).ToList();
                    }
                }
            }
            catch (Exception exception)
            {
                HelpClass.MessageBoxOperation.MessageBoxError(exception.Message);
            }
            finally
            {
                this.Close();
                Form form = Application.OpenForms["Form1"];
                TextBox textbox = (TextBox)form.Controls["txtTcNumarasi"];
                textbox.Text = "";
                textbox.Focus();
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
