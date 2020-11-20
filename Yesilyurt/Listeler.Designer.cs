namespace Yesilyurt
{
    partial class Listeler
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCiftciler = new System.Windows.Forms.Button();
            this.dataGridViewListe = new System.Windows.Forms.DataGridView();
            this.btnExceleAktar = new System.Windows.Forms.Button();
            this.btnCKS = new System.Windows.Forms.Button();
            this.btnSertifikaliTohumBasvuru = new System.Windows.Forms.Button();
            this.lblListeIsmi = new System.Windows.Forms.Label();
            this.btnMgdIcmal2019 = new System.Windows.Forms.Button();
            this.btnCks2021 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListe)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCiftciler
            // 
            this.btnCiftciler.Location = new System.Drawing.Point(468, 52);
            this.btnCiftciler.Name = "btnCiftciler";
            this.btnCiftciler.Size = new System.Drawing.Size(75, 23);
            this.btnCiftciler.TabIndex = 0;
            this.btnCiftciler.Text = "Çiftçiler";
            this.btnCiftciler.UseVisualStyleBackColor = true;
            this.btnCiftciler.Click += new System.EventHandler(this.btnCiftciler_Click);
            // 
            // dataGridViewListe
            // 
            this.dataGridViewListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListe.Location = new System.Drawing.Point(12, 96);
            this.dataGridViewListe.Name = "dataGridViewListe";
            this.dataGridViewListe.RowHeadersWidth = 51;
            this.dataGridViewListe.Size = new System.Drawing.Size(752, 342);
            this.dataGridViewListe.TabIndex = 1;
            // 
            // btnExceleAktar
            // 
            this.btnExceleAktar.Location = new System.Drawing.Point(689, 456);
            this.btnExceleAktar.Name = "btnExceleAktar";
            this.btnExceleAktar.Size = new System.Drawing.Size(75, 23);
            this.btnExceleAktar.TabIndex = 0;
            this.btnExceleAktar.Text = "Excele Aktar";
            this.btnExceleAktar.UseVisualStyleBackColor = true;
            this.btnExceleAktar.Click += new System.EventHandler(this.btnExceleAktar_Click);
            // 
            // btnCKS
            // 
            this.btnCKS.Location = new System.Drawing.Point(93, 52);
            this.btnCKS.Name = "btnCKS";
            this.btnCKS.Size = new System.Drawing.Size(75, 23);
            this.btnCKS.TabIndex = 0;
            this.btnCKS.Text = "ÇKS 2020";
            this.btnCKS.UseVisualStyleBackColor = true;
            this.btnCKS.Click += new System.EventHandler(this.btnCKS_Click);
            // 
            // btnSertifikaliTohumBasvuru
            // 
            this.btnSertifikaliTohumBasvuru.Location = new System.Drawing.Point(174, 52);
            this.btnSertifikaliTohumBasvuru.Name = "btnSertifikaliTohumBasvuru";
            this.btnSertifikaliTohumBasvuru.Size = new System.Drawing.Size(154, 23);
            this.btnSertifikaliTohumBasvuru.TabIndex = 0;
            this.btnSertifikaliTohumBasvuru.Text = "Sertifikalı Tohum Başvuru";
            this.btnSertifikaliTohumBasvuru.UseVisualStyleBackColor = true;
            this.btnSertifikaliTohumBasvuru.Click += new System.EventHandler(this.btnSertifikaliTohumBasvuru_Click);
            // 
            // lblListeIsmi
            // 
            this.lblListeIsmi.AutoSize = true;
            this.lblListeIsmi.Location = new System.Drawing.Point(12, 21);
            this.lblListeIsmi.Name = "lblListeIsmi";
            this.lblListeIsmi.Size = new System.Drawing.Size(35, 13);
            this.lblListeIsmi.TabIndex = 2;
            this.lblListeIsmi.Text = "label1";
            // 
            // btnMgdIcmal2019
            // 
            this.btnMgdIcmal2019.Location = new System.Drawing.Point(334, 52);
            this.btnMgdIcmal2019.Name = "btnMgdIcmal2019";
            this.btnMgdIcmal2019.Size = new System.Drawing.Size(128, 23);
            this.btnMgdIcmal2019.TabIndex = 3;
            this.btnMgdIcmal2019.Text = "MGD İcmal 2019";
            this.btnMgdIcmal2019.UseVisualStyleBackColor = true;
            this.btnMgdIcmal2019.Click += new System.EventHandler(this.btnMgdIcmal2019_Click);
            // 
            // btnCks2021
            // 
            this.btnCks2021.Location = new System.Drawing.Point(12, 52);
            this.btnCks2021.Name = "btnCks2021";
            this.btnCks2021.Size = new System.Drawing.Size(75, 23);
            this.btnCks2021.TabIndex = 4;
            this.btnCks2021.Text = "ÇKS 2021";
            this.btnCks2021.UseVisualStyleBackColor = true;
            this.btnCks2021.Click += new System.EventHandler(this.btnCks2021_Click);
            // 
            // Listeler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(777, 491);
            this.Controls.Add(this.btnCks2021);
            this.Controls.Add(this.btnMgdIcmal2019);
            this.Controls.Add(this.lblListeIsmi);
            this.Controls.Add(this.dataGridViewListe);
            this.Controls.Add(this.btnExceleAktar);
            this.Controls.Add(this.btnSertifikaliTohumBasvuru);
            this.Controls.Add(this.btnCKS);
            this.Controls.Add(this.btnCiftciler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Listeler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listeler";
            this.Load += new System.EventHandler(this.Excel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.Button btnCiftciler;
        private System.Windows.Forms.DataGridView dataGridViewListe;
        private System.Windows.Forms.Button btnExceleAktar;
        private System.Windows.Forms.Button btnCKS;
        private System.Windows.Forms.Button btnSertifikaliTohumBasvuru;
        private System.Windows.Forms.Label lblListeIsmi;
        private System.Windows.Forms.Button btnMgdIcmal2019;
        private System.Windows.Forms.Button btnCks2021;
    }
}