using Deneme.Business;
using Deneme.Business._2020;
using Entity._2020;
using System;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
namespace Yesilyurt._2020
{
    public partial class Cks2020 : Form
    {
        Cks2020Bll bll;
        public Cks2020()
        {
            InitializeComponent();
            bll = new Cks2020Bll();
        }
        private void CKS_Load(object sender, EventArgs e)
        {
            dataGridViewListe.DataSource = bll.GetAll().OrderByDescending(I => I.DosyaNo).ToList();
            dataGridViewListe.Columns["Id"].Visible = false;
            lblToplam.Text = $"Toplam {dataGridViewListe.RowCount} kişi";


            txtTcNumarasi.Focus();
        }
        
        private void dataGridViewListe_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string tc = dataGridViewListe.CurrentRow.Cells["TcKimlikNo"].Value.ToString();
            CKS2020 result = bll.GetAll().Where(I => I.TcKimlikNo == tc).FirstOrDefault();
            if (result != null)
            {
                Cks2020Guncelle form = new Cks2020Guncelle(result);
                form.ShowDialog();
            }
        }
        private void txtTcNumarasi_TextChanged(object sender, EventArgs e)
        {
            var Liste = bll.GetAll();
            var textBoxText = txtTcNumarasi.Text.ToUpper(new CultureInfo("tr-TR", false));
            var result = from i in Liste
                         where i.TcKimlikNo.Contains(textBoxText)
                         select i;
            dataGridViewListe.DataSource = result.ToList();
        }

        private void btnGetAllList_Click(object sender, EventArgs e)
        {
            dataGridViewListe.DataSource = bll.GetAll().OrderByDescending(I => I.DosyaNo).ToList();
            lblToplam.Text = $"Toplam {dataGridViewListe.RowCount} kişi";
        }

       
    }
}
