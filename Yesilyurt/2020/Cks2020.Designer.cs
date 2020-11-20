namespace Yesilyurt._2020
{
    partial class Cks2020
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
            this.dataGridViewListe = new System.Windows.Forms.DataGridView();
            this.btnGetAllList = new System.Windows.Forms.Button();
            this.lblToplam = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTcNumarasi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListe)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewListe
            // 
            this.dataGridViewListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListe.Location = new System.Drawing.Point(12, 77);
            this.dataGridViewListe.Name = "dataGridViewListe";
            this.dataGridViewListe.RowHeadersWidth = 51;
            this.dataGridViewListe.Size = new System.Drawing.Size(776, 390);
            this.dataGridViewListe.TabIndex = 0;
            this.dataGridViewListe.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewListe_CellDoubleClick);
            // 
            // btnGetAllList
            // 
            this.btnGetAllList.Location = new System.Drawing.Point(12, 10);
            this.btnGetAllList.Name = "btnGetAllList";
            this.btnGetAllList.Size = new System.Drawing.Size(172, 39);
            this.btnGetAllList.TabIndex = 1;
            this.btnGetAllList.Text = "Listeyi yinelemek için tıklayınız...";
            this.btnGetAllList.UseVisualStyleBackColor = true;
            this.btnGetAllList.Click += new System.EventHandler(this.btnGetAllList_Click);
            // 
            // lblToplam
            // 
            this.lblToplam.AutoSize = true;
            this.lblToplam.Location = new System.Drawing.Point(10, 52);
            this.lblToplam.Name = "lblToplam";
            this.lblToplam.Size = new System.Drawing.Size(16, 13);
            this.lblToplam.TabIndex = 2;
            this.lblToplam.Text = "...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(440, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Aramak istediğiniz TC numrasını giriniz.";
            // 
            // txtTcNumarasi
            // 
            this.txtTcNumarasi.Location = new System.Drawing.Point(633, 10);
            this.txtTcNumarasi.Name = "txtTcNumarasi";
            this.txtTcNumarasi.Size = new System.Drawing.Size(156, 20);
            this.txtTcNumarasi.TabIndex = 4;
            this.txtTcNumarasi.TextChanged += new System.EventHandler(this.txtTcNumarasi_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(440, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(350, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Güncellemek istediğiniz kaydın üzerine gelin ve mouse ile iki kere tıklayın.";
            // 
            // Cks2020
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 476);
            this.Controls.Add(this.txtTcNumarasi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblToplam);
            this.Controls.Add(this.btnGetAllList);
            this.Controls.Add(this.dataGridViewListe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Cks2020";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CKS 2020 Kayıtları";
            this.Load += new System.EventHandler(this.CKS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.DataGridView dataGridViewListe;
        private System.Windows.Forms.Button btnGetAllList;
        private System.Windows.Forms.Label lblToplam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTcNumarasi;
        private System.Windows.Forms.Label label2;
    }
}