using Deneme.Business._2021;
using Entity._2021;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace Yesilyurt._2021
{
    public partial class Cks2021Form : Form
    {
        Cks2021Bll bll;
        public Cks2021Form()
        {
            InitializeComponent();
            bll = new Cks2021Bll();

        }

        private void Cks2021Form_Load(object sender, System.EventArgs e)
        {
            dataGridViewListe.DataSource = bll.GetAll().OrderByDescending(I => I.DosyaNo).ToList();
            dataGridViewListe.Columns["Id"].Visible = false;
            lblToplam.Text = $"Toplam {dataGridViewListe.RowCount} kişi";


            txtTcNumarasi.Focus();
        }



        private void dataGridViewListe_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Datagridview row count 0 ise içeride herhangi bir kayıt olmadığından 
            //herhangi bir işlem yapılmayacak.
            int rowCountOfDatagridview = dataGridViewListe.RowCount;
            if (rowCountOfDatagridview != 0)
            {
                string tc = dataGridViewListe.CurrentRow.Cells["TcKimlikNo"].Value.ToString();
                CKS2021 result = bll.GetAll().Where(I => I.TcKimlikNo == tc).FirstOrDefault();
                if (result != null)
                {

                    Cks2021UpdateForm cks2021UpdateForm = new Cks2021UpdateForm(result);
                    cks2021UpdateForm.ShowDialog();
                }
            }

        }

        private void txtTcNumarasi_TextChanged(object sender, System.EventArgs e)
        {
            //Datagridview row count 0 ise içeride herhangi bir kayıt olmadığından 
            //herhangi bir işlem yapılmayacak.
            int rowCountOfDatagridview = dataGridViewListe.RowCount;
            if (rowCountOfDatagridview != 0)
            {
                var Liste = bll.GetAll();
                var textBoxText = txtTcNumarasi.Text.ToUpper(new CultureInfo("tr-TR", false));
                var result = from i in Liste
                             where i.TcKimlikNo.Contains(textBoxText)
                             select i;
                dataGridViewListe.DataSource = result.ToList();
            }
        }

        private void btnGetAllList_Click(object sender, System.EventArgs e)
        {
            dataGridViewListe.DataSource = bll.GetAll().OrderByDescending(I => I.DosyaNo).ToList();
            lblToplam.Text = $"Toplam {dataGridViewListe.RowCount} kişi";
        }
    }
}
