using Deneme.Business._2020;
using Entity._2020;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
namespace Yesilyurt._2020
{
    public partial class Cks2020Guncelle : Form
    {
        CKS2020 _ciftci;
        Cks2020Bll bll;
        public Cks2020Guncelle(CKS2020 ciftci)
        {
            InitializeComponent();
            _ciftci = ciftci;
            bll = new Cks2020Bll();
        }
        public Cks2020Guncelle()
        {
            InitializeComponent();
            _ciftci = null;
            bll = new Cks2020Bll();

        }

        public void CiftciFormaYazdır()
        {
            txtCiftciId.Text = "000" + _ciftci.Id.ToString();
            txtDosyaNo.Text = _ciftci.DosyaNo.ToString();
            txtTcNo.Text = _ciftci.TcKimlikNo;
            txtAdiSoyadi.Text = _ciftci.AdSoyad;
            txtBabaAdi.Text = _ciftci.BabaAdi;
            cmbKoyMahalle.Text = _ciftci.KoyMahalle;
            txtTarih.Text = _ciftci.KayitTarih.ToShortDateString();
            txtCepTelefon.Text = _ciftci.CepTelefon;
            txtEvTelefon.Text = _ciftci.EvTelefon;
        }
        public CKS2020 updatedCiftci()
        {
            _ciftci.DosyaNo = Convert.ToInt32(txtDosyaNo.Text);
            _ciftci.KayitTarih = Convert.ToDateTime(txtTarih.Text);
            _ciftci.KoyMahalle = cmbKoyMahalle.Text;
            _ciftci.CepTelefon = txtCepTelefon.Text;
            _ciftci.EvTelefon = txtEvTelefon.Text;
            return _ciftci;

        }
        private void CksGuncelle_Load(object sender, EventArgs e)
        {
            if (_ciftci != null)
            {
                CiftciFormaYazdır();

            }

        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            CKS2020 result = updatedCiftci();
           
            bll.Update(result);
            Form form = Application.OpenForms["Cks2020"];
            DataGridView dataGridViewListe = (DataGridView)form.Controls["dataGridViewListe"];
            dataGridViewListe.DataSource = bll.GetAll().OrderByDescending(I => I.DosyaNo).ToList();
            Label lblToplam = (Label)form.Controls["lblToplam"];
            lblToplam.Text = $"Toplam {dataGridViewListe.RowCount} kişi";
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = HelpClass.MessageBoxOperation.MessageBoxQuestion("Kaydı silmek istiyor musunuz?");
            if (dr == DialogResult.Yes)
            {
                
                bll.Delete(_ciftci);
                Form form = Application.OpenForms["Cks2020"];
                DataGridView dataGridViewListe = (DataGridView)form.Controls["dataGridViewListe"];
                dataGridViewListe.DataSource = bll.GetAll().OrderByDescending(I => I.DosyaNo).ToList();
                Label lblToplam = (Label)form.Controls["lblToplam"];
                lblToplam.Text = $"Toplam {dataGridViewListe.RowCount} kişi";
                this.Close();
            }

        }
    }
}
