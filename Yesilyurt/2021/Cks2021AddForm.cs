using Deneme.Business._2021;
using Entity;
using Entity._2021;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Yesilyurt._2021
{
    public partial class Cks2021AddForm : Form
    {
        Ciftci isletme;
        Cks2021Bll bll;
        public Cks2021AddForm(Ciftci isletmeInfo)
        {
            InitializeComponent();
            isletme = isletmeInfo;
            bll = new Cks2021Bll();

        }

        private void Cks2021AddForm_Load(object sender, EventArgs e)
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
            int dosyaNo = 1;
            //Kayıt yapılacak kişiye dosya numarası verilecek.
            //enson kaydı okuyacak ve son kaydın dosya numarasını 1 arttırıp yeni kişiye verecek.
            var gelenKayit = bll.GetAll().OrderByDescending(I => I.DosyaNo).FirstOrDefault();
            if (gelenKayit!=null)
            {
                dosyaNo = gelenKayit.DosyaNo + 1;
            }
           
            return dosyaNo.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                CKS2021 CKS = new CKS2021();
                CKS.AdSoyad = txtAdiSoyadi.Text;
                CKS.BabaAdi = txtBabaAdi.Text;
                CKS.KoyMahalle = txtkoy.Text;
                CKS.TcKimlikNo = txtTcNumarasi.Text;
                CKS.CepTelefon = txtCepTelefon.Text;
                CKS.EvTelefon = txtEvTelefon.Text;
                CKS.DosyaNo = Convert.ToInt32(txtDosyaNo.Text);
                if (txtTarih.Text == DateTime.Now.ToShortDateString())
                {
                    CKS.KayitTarih = Convert.ToDateTime(txtTarih.Text);

                    DialogResult dr = HelpClass.MessageBoxOperation.MessageBoxQuestion("Tarih kısmında güncelleme yapmadınız. Devam etmek istiyor musunuz?");
                    if (dr == DialogResult.Yes)
                    {
                        //ekleme işlemini yapacak...
                        bll.Add(CKS);
                        //daha sonra çks listesi açık değilse açacak..
                        Form cks2021Form = Application.OpenForms["Cks2021Form"];
                        if (cks2021Form == null)
                        {
                            //form açılırken güncel listeyi sana gösterecek..
                            Cks2021Form yeniCks2021FormAc = new  Cks2021Form();
                            yeniCks2021FormAc.Show();
                        }
                        else
                        {
                            //eğer açıksa liste içinde güncellenmiş listeyi sana gösterecek...
                            DataGridView dgw = (DataGridView)cks2021Form.Controls["dataGridViewListe"];
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
                    Form cks2021Form = Application.OpenForms["Cks2021Form"];
                    if (cks2021Form == null)
                    {
                        //form açılırken güncel listeyi sana gösterecek..
                        Cks2021Form yeniCks2021Form = new  Cks2021Form();
                        yeniCks2021Form.Show();
                    }
                    else
                    {
                        //eğer açıksa liste içinde güncellenmiş listeyi sana gösterecek...
                        DataGridView dgw = (DataGridView)cks2021Form.Controls["dataGridViewListe"];
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
