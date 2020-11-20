namespace Yesilyurt._2021
{
    partial class Cks2021Form
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
            this.txtTcNumarasi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblToplam = new System.Windows.Forms.Label();
            this.btnGetAllList = new System.Windows.Forms.Button();
            this.dataGridViewListe = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListe)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTcNumarasi
            // 
            this.txtTcNumarasi.Location = new System.Drawing.Point(839, 12);
            this.txtTcNumarasi.Margin = new System.Windows.Forms.Padding(4);
            this.txtTcNumarasi.Name = "txtTcNumarasi";
            this.txtTcNumarasi.Size = new System.Drawing.Size(207, 22);
            this.txtTcNumarasi.TabIndex = 10;
            this.txtTcNumarasi.TextChanged += new System.EventHandler(this.txtTcNumarasi_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(582, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(469, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Güncellemek istediğiniz kaydın üzerine gelin ve mouse ile iki kere tıklayın.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(582, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Aramak istediğiniz TC numrasını giriniz.";
            // 
            // lblToplam
            // 
            this.lblToplam.AutoSize = true;
            this.lblToplam.Location = new System.Drawing.Point(8, 64);
            this.lblToplam.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblToplam.Name = "lblToplam";
            this.lblToplam.Size = new System.Drawing.Size(20, 17);
            this.lblToplam.TabIndex = 7;
            this.lblToplam.Text = "...";
            // 
            // btnGetAllList
            // 
            this.btnGetAllList.Location = new System.Drawing.Point(11, 12);
            this.btnGetAllList.Margin = new System.Windows.Forms.Padding(4);
            this.btnGetAllList.Name = "btnGetAllList";
            this.btnGetAllList.Size = new System.Drawing.Size(229, 48);
            this.btnGetAllList.TabIndex = 6;
            this.btnGetAllList.Text = "Listeyi yinelemek için tıklayınız...";
            this.btnGetAllList.UseVisualStyleBackColor = true;
            this.btnGetAllList.Click += new System.EventHandler(this.btnGetAllList_Click);
            // 
            // dataGridViewListe
            // 
            this.dataGridViewListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListe.Location = new System.Drawing.Point(11, 95);
            this.dataGridViewListe.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewListe.Name = "dataGridViewListe";
            this.dataGridViewListe.RowHeadersWidth = 51;
            this.dataGridViewListe.Size = new System.Drawing.Size(1035, 480);
            this.dataGridViewListe.TabIndex = 5;
            this.dataGridViewListe.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewListe_CellDoubleClick);
            // 
            // Cks2021Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 542);
            this.Controls.Add(this.txtTcNumarasi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblToplam);
            this.Controls.Add(this.btnGetAllList);
            this.Controls.Add(this.dataGridViewListe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Cks2021Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Çks 2021 Kayıtları";
            this.Load += new System.EventHandler(this.Cks2021Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTcNumarasi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblToplam;
        private System.Windows.Forms.Button btnGetAllList;
        private System.Windows.Forms.DataGridView dataGridViewListe;
    }
}