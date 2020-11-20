namespace Yesilyurt
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTcNumarasi = new System.Windows.Forms.TextBox();
            this.btnTbs = new System.Windows.Forms.Button();
            this.btnCKSListe = new System.Windows.Forms.Button();
            this.lblToplamKisi = new System.Windows.Forms.Label();
            this.txtSerachIsim = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSertifikaliTohum = new System.Windows.Forms.Button();
            this.btnListeler = new System.Windows.Forms.Button();
            this.btnJsonBackup = new System.Windows.Forms.Button();
            this.btnJsonRestore = new System.Windows.Forms.Button();
            this.btnCks2021Aktar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTcAra = new System.Windows.Forms.Button();
            this.btnIsimAra = new System.Windows.Forms.Button();
            this.btnCks2021Listele = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListe)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewListe
            // 
            this.dataGridViewListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListe.Location = new System.Drawing.Point(12, 218);
            this.dataGridViewListe.Name = "dataGridViewListe";
            this.dataGridViewListe.RowHeadersWidth = 51;
            this.dataGridViewListe.Size = new System.Drawing.Size(776, 220);
            this.dataGridViewListe.TabIndex = 0;
            this.dataGridViewListe.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewListe_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Aramak istediğiniz Tc numarasını giriniz.";
            // 
            // txtTcNumarasi
            // 
            this.txtTcNumarasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTcNumarasi.Location = new System.Drawing.Point(15, 36);
            this.txtTcNumarasi.Name = "txtTcNumarasi";
            this.txtTcNumarasi.Size = new System.Drawing.Size(182, 22);
            this.txtTcNumarasi.TabIndex = 0;
            // 
            // btnTbs
            // 
            this.btnTbs.Location = new System.Drawing.Point(263, 34);
            this.btnTbs.Name = "btnTbs";
            this.btnTbs.Size = new System.Drawing.Size(75, 23);
            this.btnTbs.TabIndex = 4;
            this.btnTbs.Text = "Tbsden Ekle";
            this.btnTbs.UseVisualStyleBackColor = true;
            this.btnTbs.Click += new System.EventHandler(this.btnTbs_Click);
            // 
            // btnCKSListe
            // 
            this.btnCKSListe.Location = new System.Drawing.Point(725, 20);
            this.btnCKSListe.Name = "btnCKSListe";
            this.btnCKSListe.Size = new System.Drawing.Size(63, 50);
            this.btnCKSListe.TabIndex = 5;
            this.btnCKSListe.Text = "ÇKS 2020";
            this.btnCKSListe.UseVisualStyleBackColor = true;
            this.btnCKSListe.Click += new System.EventHandler(this.btnCKSListe_Click);
            // 
            // lblToplamKisi
            // 
            this.lblToplamKisi.AutoSize = true;
            this.lblToplamKisi.Location = new System.Drawing.Point(9, 202);
            this.lblToplamKisi.Name = "lblToplamKisi";
            this.lblToplamKisi.Size = new System.Drawing.Size(62, 13);
            this.lblToplamKisi.TabIndex = 1;
            this.lblToplamKisi.Text = "Çiftçi Listesi";
            // 
            // txtSerachIsim
            // 
            this.txtSerachIsim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSerachIsim.Location = new System.Drawing.Point(15, 90);
            this.txtSerachIsim.Name = "txtSerachIsim";
            this.txtSerachIsim.Size = new System.Drawing.Size(182, 22);
            this.txtSerachIsim.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Aramak istediğiniz ismi giriniz.";
            // 
            // btnSertifikaliTohum
            // 
            this.btnSertifikaliTohum.Location = new System.Drawing.Point(725, 77);
            this.btnSertifikaliTohum.Name = "btnSertifikaliTohum";
            this.btnSertifikaliTohum.Size = new System.Drawing.Size(63, 55);
            this.btnSertifikaliTohum.TabIndex = 7;
            this.btnSertifikaliTohum.Text = "Sertifikalı Tohum 2020 ";
            this.btnSertifikaliTohum.UseVisualStyleBackColor = true;
            this.btnSertifikaliTohum.Click += new System.EventHandler(this.btnSertifikaliTohum_Click);
            // 
            // btnListeler
            // 
            this.btnListeler.Location = new System.Drawing.Point(725, 139);
            this.btnListeler.Name = "btnListeler";
            this.btnListeler.Size = new System.Drawing.Size(63, 38);
            this.btnListeler.TabIndex = 8;
            this.btnListeler.Text = "Listeler";
            this.btnListeler.UseVisualStyleBackColor = true;
            this.btnListeler.Click += new System.EventHandler(this.btnListeler_Click);
            // 
            // btnJsonBackup
            // 
            this.btnJsonBackup.Location = new System.Drawing.Point(605, 453);
            this.btnJsonBackup.Margin = new System.Windows.Forms.Padding(2);
            this.btnJsonBackup.Name = "btnJsonBackup";
            this.btnJsonBackup.Size = new System.Drawing.Size(89, 29);
            this.btnJsonBackup.TabIndex = 9;
            this.btnJsonBackup.Text = "Json Backup";
            this.btnJsonBackup.UseVisualStyleBackColor = true;
            this.btnJsonBackup.Click += new System.EventHandler(this.btnJsonBackup_Click);
            // 
            // btnJsonRestore
            // 
            this.btnJsonRestore.Location = new System.Drawing.Point(699, 453);
            this.btnJsonRestore.Margin = new System.Windows.Forms.Padding(2);
            this.btnJsonRestore.Name = "btnJsonRestore";
            this.btnJsonRestore.Size = new System.Drawing.Size(89, 29);
            this.btnJsonRestore.TabIndex = 9;
            this.btnJsonRestore.Text = "Json Restore";
            this.btnJsonRestore.UseVisualStyleBackColor = true;
            this.btnJsonRestore.Click += new System.EventHandler(this.btnJsonRestore_Click);
            // 
            // btnCks2021Aktar
            // 
            this.btnCks2021Aktar.Location = new System.Drawing.Point(263, 130);
            this.btnCks2021Aktar.Name = "btnCks2021Aktar";
            this.btnCks2021Aktar.Size = new System.Drawing.Size(128, 23);
            this.btnCks2021Aktar.TabIndex = 10;
            this.btnCks2021Aktar.Text = "Çks 2021\'ye Aktar";
            this.btnCks2021Aktar.UseVisualStyleBackColor = true;
            this.btnCks2021Aktar.Click += new System.EventHandler(this.btnCks2021Aktar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(245, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Çiftçiyi ÇKS 2021 kayıtlarına eklemek için tıklayınız.";
            // 
            // btnTcAra
            // 
            this.btnTcAra.Location = new System.Drawing.Point(201, 36);
            this.btnTcAra.Margin = new System.Windows.Forms.Padding(2);
            this.btnTcAra.Name = "btnTcAra";
            this.btnTcAra.Size = new System.Drawing.Size(56, 21);
            this.btnTcAra.TabIndex = 11;
            this.btnTcAra.Text = "Ara";
            this.btnTcAra.UseVisualStyleBackColor = true;
            this.btnTcAra.Click += new System.EventHandler(this.btnTcAra_Click);
            // 
            // btnIsimAra
            // 
            this.btnIsimAra.Location = new System.Drawing.Point(201, 90);
            this.btnIsimAra.Margin = new System.Windows.Forms.Padding(2);
            this.btnIsimAra.Name = "btnIsimAra";
            this.btnIsimAra.Size = new System.Drawing.Size(56, 21);
            this.btnIsimAra.TabIndex = 11;
            this.btnIsimAra.Text = "Ara";
            this.btnIsimAra.UseVisualStyleBackColor = true;
            this.btnIsimAra.Click += new System.EventHandler(this.btnIsimAra_Click);
            // 
            // btnCks2021Listele
            // 
            this.btnCks2021Listele.Location = new System.Drawing.Point(657, 20);
            this.btnCks2021Listele.Margin = new System.Windows.Forms.Padding(2);
            this.btnCks2021Listele.Name = "btnCks2021Listele";
            this.btnCks2021Listele.Size = new System.Drawing.Size(63, 50);
            this.btnCks2021Listele.TabIndex = 12;
            this.btnCks2021Listele.Text = "ÇKS 2021";
            this.btnCks2021Listele.UseVisualStyleBackColor = true;
            this.btnCks2021Listele.Click += new System.EventHandler(this.btnCks2021Listele_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 492);
            this.Controls.Add(this.btnCks2021Listele);
            this.Controls.Add(this.btnIsimAra);
            this.Controls.Add(this.btnTcAra);
            this.Controls.Add(this.btnCks2021Aktar);
            this.Controls.Add(this.btnJsonRestore);
            this.Controls.Add(this.btnJsonBackup);
            this.Controls.Add(this.btnListeler);
            this.Controls.Add(this.btnSertifikaliTohum);
            this.Controls.Add(this.txtSerachIsim);
            this.Controls.Add(this.btnCKSListe);
            this.Controls.Add(this.btnTbs);
            this.Controls.Add(this.txtTcNumarasi);
            this.Controls.Add(this.lblToplamKisi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewListe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Çiftçiler";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.DataGridView dataGridViewListe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTcNumarasi;
        private System.Windows.Forms.Button btnTbs;
        private System.Windows.Forms.Button btnCKSListe;
        private System.Windows.Forms.Label lblToplamKisi;
        private System.Windows.Forms.TextBox txtSerachIsim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSertifikaliTohum;
        private System.Windows.Forms.Button btnListeler;
        private System.Windows.Forms.Button btnJsonBackup;
        private System.Windows.Forms.Button btnJsonRestore;
        private System.Windows.Forms.Button btnCks2021Aktar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTcAra;
        private System.Windows.Forms.Button btnIsimAra;
        private System.Windows.Forms.Button btnCks2021Listele;
    }
}
