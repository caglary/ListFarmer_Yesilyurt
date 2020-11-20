using Deneme.Business;
using Entity;
using System;
using System.Windows.Forms;
namespace Yesilyurt
{
    public partial class CiftciGuncelle : Form
    {
        Ciftci _ciftci;
        CiftcilerBll bll;
        public CiftciGuncelle(Ciftci ciftci)
        {
            InitializeComponent();
            _ciftci = ciftci;
            bll = new CiftcilerBll();
        }
        private void CiftciGuncelle_Load(object sender, EventArgs e)
        {
            CiftcininBilgileriniYaz(_ciftci);
        }
        private void CiftcininBilgileriniYaz(Ciftci ciftci)
        {
            lblId.Text = ciftci.Id.ToString();
            txtAnneAdi.Text = ciftci.AnneAdi;
            txtBabaAdi.Text = ciftci.BabaAdi;
            txtCepTelefonu.Text = ciftci.CepTelefon;
            txtCinsiyet.Text = ciftci.Cinsiyet;
            txtDogumTarihi.Text = ciftci.DogumTarihi.ToString();
            txtEmail.Text = ciftci.Email;
            txtEvTelefonu.Text = ciftci.EvTelefon;
            txtil.Text = ciftci.Il;
            txtilçe.Text = ciftci.Ilce;
            txtIsim.Text = ciftci.Ad;
            txtMedeniDurum.Text = ciftci.MedeniDurum;
            txtOlumTarihi.Text = ciftci.OlumTarihi;
            txtSoyisim.Text = ciftci.Soyad;
            txtTcNo.Text = ciftci.TcKimlikNo;
            comboboxMahalleKoy.Text = ciftci.KoyMahalle;
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateIslemi();
        }
        private Ciftci UpdatedCiftci()
        {
            Entity.Ciftci updatedCiftci = new Ciftci();
            updatedCiftci.AnneAdi = txtAnneAdi.Text;
            updatedCiftci.BabaAdi = txtBabaAdi.Text;
            updatedCiftci.CepTelefon = txtCepTelefonu.Text;
            updatedCiftci.Cinsiyet = txtCinsiyet.Text;
            updatedCiftci.DogumTarihi = Convert.ToDateTime(txtDogumTarihi.Text);
            updatedCiftci.Email = txtEmail.Text;
            updatedCiftci.EvTelefon = txtEvTelefonu.Text;
            updatedCiftci.Id = _ciftci.Id;
            updatedCiftci.Il = txtil.Text;
            updatedCiftci.Ilce = txtilçe.Text;
            updatedCiftci.KoyMahalle = comboboxMahalleKoy.Text;
            updatedCiftci.MedeniDurum = txtMedeniDurum.Text;
            updatedCiftci.Ad = txtIsim.Text;
            updatedCiftci.Soyad = txtSoyisim.Text;
            updatedCiftci.TcKimlikNo = txtTcNo.Text;
            return updatedCiftci;
        }
        private void btnTbs_Click(object sender, EventArgs e)
        {
            try
            {
                //Tbs den işletme bilgilerini getiriyoruz.
                var result = bll.IsletmeBilgiGetir(txtTcNo.Text);
                //gelen işletme bilgilerini form ekranına dolduruyoruz...
                CiftcininBilgileriniYaz(result);
                //ekranda doldurulan bilgileri database içerinde güncelleme işlemi yapıyoruz.
                UpdateIslemi();
            }
            catch (Exception exception)
            {

                HelpClass.MessageBoxOperation.MessageBoxError(exception.Message);
            }

        }
        private void UpdateIslemi()
        {
            Ciftci updatedCiftci = UpdatedCiftci();
            try
            {
                bll.Update(updatedCiftci);
            }
            catch (Exception exception)
            {
                HelpClass.MessageBoxOperation.MessageBoxError(exception.Message);
            }
            //anaformu ekrana getirip güncel kaydı görmek istiyoruz..
            Form anasayfa = Application.OpenForms["Form1"];
            TextBox textbox = (TextBox)anasayfa.Controls["txtTcNumarasi"];
            textbox.Text = "";
            textbox.Text = updatedCiftci.TcKimlikNo;
            Label lblToplamKisi = (Label)anasayfa.Controls["lblToplamKisi"];
            DataGridView dataGridViewListe = (DataGridView)anasayfa.Controls["dataGridViewListe"];
            lblToplamKisi.Text = $"Çiftçi listesi, toplam {dataGridViewListe.RowCount} adet çiftçi kayıtlıdır.";
        }
    }
}
