using Deneme.Business._2020;
using Entity._2020;
using System;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
namespace Yesilyurt._2020
{
    public partial class SertifikaliTohum2020 : Form
    {
        SertifikaliTohum2020Bll bll;
        public SertifikaliTohum2020()
        {
            InitializeComponent();
            bll = new SertifikaliTohum2020Bll();
        }
        private void SertifikaliTohum2020_Load(object sender, EventArgs e)
        {

            dataGridViewListe.DataSource = bll.GetAll().OrderByDescending(I => I.SertifikaliTohumDosyaNo).ToList();

            txtBasvuruYili.Text = "2020";
            txtTcNo.Focus();
            dataGridViewListe.Columns["Id"].Visible = false;
            dataGridViewListe.Columns["BasvuruYili"].Visible = false;


            //dataGridViewListe.Columns["CksDosyaNo"].Visible = false;
            //dataGridViewListe.Columns["TcNumarasi"].Visible = false;
            //dataGridViewListe.Columns["AdiSoyadi"].Visible = false;
            //dataGridViewListe.Columns["BabaAdi"].Visible = false;
            //dataGridViewListe.Columns["Koy"].Visible = false;

        }
        private void dataGridViewListe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string yakalananDeger = dataGridViewListe.CurrentCell.Value.ToString();
                Clipboard.SetText(yakalananDeger);
            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            int result = 0;
            var entity = CreateNewEntity(Buton.Kaydet);
            if (entity != null)
            {
                var mukerrer = bll.MukerrerKayit(entity);
                if (mukerrer is true)
                {
                    DialogResult dr = HelpClass.MessageBoxOperation.MessageBoxQuestion("Aynı Fatura numrası ile kayıt mevcuttur. Kayıt işlemine devam edilsin mi?");
                    if (dr == DialogResult.Yes)
                    {
                        bll.Add(entity);
                        result = 1;
                    }
                }
                else
                {
                    bll.Add(entity);
                    result = 1;
                }
            }
            if (result == 1) Temizle(entity);
        }
        private void Temizle()
        {
            dataGridViewListe.DataSource = bll.GetAll().OrderByDescending(I => I.SertifikaliTohumDosyaNo).ToList();
            txtId.Text = "";
            txtCksDosyaNo.Text = "";
            txtBasvuruYili.Text = "2020";
            txtSertifikaliTohumDosyaNo.Text = "";
            txtAdiSoyadi.Text = "";
            txtBabaAdi.Text = "";
            txtKoyMahalle.Text = "";
            txtMüracaatTarihi.Text = "";
            txtFaturaNo.Text = "";
            txtFaturaTarihi.Text = "";
            txtFirmaAdi.Text = "";
            txtUrun.Text = "";
            txtUrunCesidi.Text = "";
            txtMiktari.Text = "";
            txtBirimFiyati.Text = "";
            txtToplamMaliyet.Text = "";
            txtTcNo.Focus();
            txtSertifikaNo.Text = "";

        }
        private void Temizle(Entity._2020.SertifikaliTohum2020 Entity)
        {
            dataGridViewListe.DataSource = bll.GetAll().Where(I => I.TcNumarasi == Entity.TcNumarasi).ToList();
            txtId.Text = "";
            txtCksDosyaNo.Text = "";
            txtBasvuruYili.Text = "2020";
            txtSertifikaliTohumDosyaNo.Text = "";
            txtAdiSoyadi.Text = "";
            txtBabaAdi.Text = "";
            txtKoyMahalle.Text = "";
            txtMüracaatTarihi.Text = "";
            txtFaturaNo.Text = "";
            txtFaturaTarihi.Text = "";
            txtFirmaAdi.Text = "";
            txtUrun.Text = "";
            txtUrunCesidi.Text = "";
            txtMiktari.Text = "";
            txtBirimFiyati.Text = "";
            txtToplamMaliyet.Text = "";
            txtTcNo.Focus();
            txtSertifikaNo.Text = "";
        }
        private Entity._2020.SertifikaliTohum2020 CreateNewEntity(Buton enumButon)
        {
            try
            {
                Entity._2020.SertifikaliTohum2020 entitiySertifikaliTohum = new Entity._2020.SertifikaliTohum2020();
                if (enumButon != Buton.Kaydet)
                {
                    entitiySertifikaliTohum.Id = Convert.ToInt32(txtId.Text);
                }
                entitiySertifikaliTohum.BasvuruYili = Convert.ToInt32(txtBasvuruYili.Text);
                entitiySertifikaliTohum.CksDosyaNo = Convert.ToInt32(txtCksDosyaNo.Text);
                entitiySertifikaliTohum.SertifikaliTohumDosyaNo = Convert.ToInt32(txtSertifikaliTohumDosyaNo.Text);
                entitiySertifikaliTohum.TcNumarasi = txtTcNo.Text;
                entitiySertifikaliTohum.AdiSoyadi = txtAdiSoyadi.Text;
                entitiySertifikaliTohum.BabaAdi = txtBabaAdi.Text;
                entitiySertifikaliTohum.Koy = txtKoyMahalle.Text;
                entitiySertifikaliTohum.MuracaatTarih = Convert.ToDateTime(txtMüracaatTarihi.Text);
                entitiySertifikaliTohum.FaturaNo = txtFaturaNo.Text;
                entitiySertifikaliTohum.FaturaTarihi = Convert.ToDateTime(txtFaturaTarihi.Text);
                entitiySertifikaliTohum.FirmaAdi = txtFirmaAdi.Text;
                entitiySertifikaliTohum.Urun = txtUrun.Text;
                entitiySertifikaliTohum.UrunCesidi = txtUrunCesidi.Text;
                entitiySertifikaliTohum.Miktari = Convert.ToDecimal(txtMiktari.Text);
                entitiySertifikaliTohum.BirimFiyati = Convert.ToDecimal(txtBirimFiyati.Text);
                entitiySertifikaliTohum.ToplamMaliyet = Convert.ToDecimal(txtToplamMaliyet.Text);
                return entitiySertifikaliTohum;
            }
            catch (Exception)
            {
                HelpClass.MessageBoxOperation.MessageBoxError("Tablodaki verileri kontrol ediniz.");
                return null;
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var entity = CreateNewEntity(Buton.Guncelle);
            if (entity != null)
            {
                bll.Update(entity);
            }
            dataGridViewListe.DataSource = bll.GetAll().Where(I => I.Id == entity.Id).ToList();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnGetir_Click(object sender, EventArgs e)
        {
            Cks2020Bll cks2020Bll = new Cks2020Bll();
            var result = cks2020Bll.GetAll().Where(I => I.TcKimlikNo == txtTcNo.Text).FirstOrDefault();
            if (result != null)
            {
                txtCksDosyaNo.Text = result.DosyaNo.ToString();
                txtAdiSoyadi.Text = result.AdSoyad;
                txtBabaAdi.Text = result.BabaAdi;
                txtKoyMahalle.Text = result.KoyMahalle;
            }
            else
            {
                HelpClass.MessageBoxOperation.MessageBoxError("Çks 2020 Listesinde herhangi bir kayıt bulunamadı.");
            }
        }
        private void dataGridViewListe_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string Id = dataGridViewListe.CurrentRow.Cells["Id"].Value.ToString();
            string BasvuruYili = dataGridViewListe.CurrentRow.Cells["BasvuruYili"].Value.ToString();
            string CksDosyaNo = dataGridViewListe.CurrentRow.Cells["CksDosyaNo"].Value.ToString();
            string SertifikaliTohumDosyaNo = dataGridViewListe.CurrentRow.Cells["SertifikaliTohumDosyaNo"].Value.ToString();
            string TcNumarasi = dataGridViewListe.CurrentRow.Cells["TcNumarasi"].Value.ToString();
            string AdiSoyadi = dataGridViewListe.CurrentRow.Cells["AdiSoyadi"].Value.ToString();
            string BabaAdi = dataGridViewListe.CurrentRow.Cells["BabaAdi"].Value.ToString();
            string Koy = dataGridViewListe.CurrentRow.Cells["Koy"].Value.ToString();
            string MuracaatTarih = dataGridViewListe.CurrentRow.Cells["MuracaatTarih"].Value.ToString();
            string FaturaNo = dataGridViewListe.CurrentRow.Cells["FaturaNo"].Value.ToString();
            string FaturaTarihi = dataGridViewListe.CurrentRow.Cells["FaturaTarihi"].Value.ToString();
            string FirmaAdi = dataGridViewListe.CurrentRow.Cells["FirmaAdi"].Value.ToString();
            string Urun = dataGridViewListe.CurrentRow.Cells["Urun"].Value.ToString();
            string UrunCesidi = dataGridViewListe.CurrentRow.Cells["UrunCesidi"].Value.ToString();
            string Miktari = dataGridViewListe.CurrentRow.Cells["Miktari"].Value.ToString();
            string BirimFiyati = dataGridViewListe.CurrentRow.Cells["BirimFiyati"].Value.ToString();
            string ToplamMaliyet = dataGridViewListe.CurrentRow.Cells["ToplamMaliyet"].Value.ToString();
            string SertifikaNo = "";
            try
            {
                SertifikaNo = dataGridViewListe.CurrentRow.Cells["SertifikaNo"].Value.ToString();
            }
            catch (Exception)
            {

                SertifikaNo="Bilinmiyor";
            }
            
            txtId.Text = Id;
            txtBasvuruYili.Text = BasvuruYili;
            txtCksDosyaNo.Text = CksDosyaNo;
            txtSertifikaliTohumDosyaNo.Text = SertifikaliTohumDosyaNo;
            txtTcNo.Text = TcNumarasi;
            txtAdiSoyadi.Text = AdiSoyadi;
            txtBabaAdi.Text = BabaAdi;
            txtKoyMahalle.Text = Koy;
            txtMüracaatTarihi.Text = MuracaatTarih;
            txtFaturaNo.Text = FaturaNo;
            txtFaturaTarihi.Text = FaturaTarihi;
            txtFirmaAdi.Text = FirmaAdi;
            txtUrun.Text = Urun;
            txtUrunCesidi.Text = UrunCesidi;
            txtMiktari.Text = Miktari;
            txtBirimFiyati.Text = BirimFiyati;
            txtToplamMaliyet.Text = ToplamMaliyet;
            txtSertifikaNo.Text = SertifikaNo;
        }
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }
        private void txtTcNo_TextChanged(object sender, EventArgs e)
        {
            var Liste = bll.GetAll();
            var textBoxText = txtTcNo.Text.ToUpper(new CultureInfo("tr-TR", false));
            var result = from i in Liste
                         where i.TcNumarasi.Contains(textBoxText)
                         select i;
            dataGridViewListe.DataSource = result.ToList();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = HelpClass.MessageBoxOperation.MessageBoxQuestion("Kaydı silmek istiyor musunuz?");
            if (dr == DialogResult.Yes)
            {

                var result = bll.GetAll().Where(I => I.Id == Convert.ToInt32(txtId.Text)).FirstOrDefault();
                int returnValue = bll.Delete(result);
                if (returnValue == 1) Temizle();
            }
        }
    }
    enum Buton
    {
        Kaydet, Guncelle
    }
}
