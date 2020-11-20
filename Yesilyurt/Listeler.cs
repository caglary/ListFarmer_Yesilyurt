using Deneme.Business;
using Deneme.Business._2019;
using Deneme.Business._2020;
using Deneme.Business._2021;
using System;
using System.Linq;
using System.Windows.Forms;
namespace Yesilyurt
{
    public partial class Listeler : Form
    {
        Cks2020Bll CKSBll;
        Cks2021Bll cks2021Bll;
        CiftcilerBll isletmeBll;
        SertifikaliTohum2020Bll sertifikaliTohumBll;
        Mgd2019Bll _mgd2019Bll;
        
        static string KayitIsmi = "";
        public Listeler()
        {
            InitializeComponent();
            CKSBll = new Cks2020Bll();
            isletmeBll = new CiftcilerBll();
            sertifikaliTohumBll = new SertifikaliTohum2020Bll();
            _mgd2019Bll = new Mgd2019Bll();
            cks2021Bll = new Cks2021Bll();
            
        }
        private void Excel_Load(object sender, EventArgs e)
        {
            dataGridViewListe.DataSource = null;
            lblListeIsmi.Text = "Liste seçiniz...";
        }
        private void btnCiftciler_Click(object sender, EventArgs e)
        {
            dataGridViewListe.DataSource = isletmeBll.GetAll().OrderByDescending(I=>I.Id).ToList();
            dataGridViewListe.Columns["Id"].Visible = false;
            lblListeIsmi.Text = $"{btnCiftciler.Text} Listesi - Toplam {dataGridViewListe.RowCount} kayıt mevcuttur.";
            KayitIsmi = $"{btnCiftciler.Text}.xls";
        }
        private void btnCKS_Click(object sender, EventArgs e)
        {
            dataGridViewListe.DataSource = CKSBll.GetAll().OrderBy(I=>I.DosyaNo).ToList();
            dataGridViewListe.Columns["Id"].Visible = false;
            lblListeIsmi.Text = $"{btnCKS.Text} Listesi - Toplam {dataGridViewListe.RowCount} kayıt mevcuttur.";
            KayitIsmi = $"{btnCKS.Text}.xls";
        }
        private void btnSertifikaliTohumBasvuru_Click(object sender, EventArgs e)
        {
            dataGridViewListe.DataSource = sertifikaliTohumBll.GetAll().OrderByDescending(I=>I.SertifikaliTohumDosyaNo).ToList();
            dataGridViewListe.Columns["Id"].Visible = false;
            dataGridViewListe.Columns["BasvuruYili"].Visible = false;
            lblListeIsmi.Text = $"{btnSertifikaliTohumBasvuru.Text} Listesi - Toplam {dataGridViewListe.RowCount} kayıt mevcuttur.";
            KayitIsmi = $"{btnSertifikaliTohumBasvuru.Text}.xls";
        }
        private void btnExceleAktar_Click(object sender, EventArgs e)
        {
            try
            {
                // creating Excel Application  
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                // creating new WorkBook within Excel application  
                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                // creating new Excelsheet in workbook  
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                // see the excel sheet behind the program  
                app.Visible = true;
                
                // get the reference of first sheet. By default its name is Sheet1.  
                // store its reference to worksheet  
                worksheet = workbook.Sheets[1];
                worksheet = workbook.ActiveSheet;
                // changing the name of active sheet  
                worksheet.Name = "Exported from gridview";
                // storing header part in Excel  
              
                for (int i = 1; i < dataGridViewListe.Columns.Count + 1; i++)
                {
                    worksheet.Cells[1, i] = dataGridViewListe.Columns[i - 1].HeaderText;
                }
                // storing Each row and column value to excel sheet  
                for (int i = 0; i < dataGridViewListe.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridViewListe.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dataGridViewListe.Rows[i].Cells[j].Value.ToString();
                    }
                }
               
                // save the application  
                //FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
                //folderBrowserDialog.ShowDialog();
                //string fileName = folderBrowserDialog.SelectedPath + "\\" + KayitIsmi;
                //KayitIsmi = $"c:\\{fileName}";
                
                //workbook.SaveAs(KayitIsmi, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                //// Exit from the application  
                //app.Quit();
            }
            catch (Exception exception)
            {
                HelpClass.MessageBoxOperation.MessageBoxError(exception.Message);
            }
        }
        private void btnMgdIcmal2019_Click(object sender, EventArgs e)
        {
            dataGridViewListe.DataSource = _mgd2019Bll.GetAll().OrderBy(I => I.MahalleKoy).ToList();
            dataGridViewListe.Columns["Id"].Visible = false;
            dataGridViewListe.Columns["SiraNo"].Visible = false;
            dataGridViewListe.Columns["Il"].Visible = false;
            dataGridViewListe.Columns["Ilce"].Visible = false;
            dataGridViewListe.Columns["DogumTarihi"].Visible = false;
            lblListeIsmi.Text = $"{btnMgdIcmal2019.Text} Listesi - Toplam {dataGridViewListe.RowCount} kayıt mevcuttur.";
            KayitIsmi = $"{btnMgdIcmal2019.Text}.xls";
        }

        private void btnCks2021_Click(object sender, EventArgs e)
        {
            dataGridViewListe.DataSource = cks2021Bll.GetAll().OrderBy(I => I.DosyaNo).ToList();
            dataGridViewListe.Columns["Id"].Visible = false;
            lblListeIsmi.Text = $"{btnCks2021.Text} Listesi - Toplam {dataGridViewListe.RowCount} kayıt mevcuttur.";
            KayitIsmi = $"{btnCks2021.Text}.xls";
        }
    }
}
