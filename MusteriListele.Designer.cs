namespace Arackiralamaproject
{
    partial class MusteriListele
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.maskedtb_telno = new System.Windows.Forms.MaskedTextBox();
            this.tb_adres = new System.Windows.Forms.TextBox();
            this.tb_eposta = new System.Windows.Forms.TextBox();
            this.tb_adsoyad = new System.Windows.Forms.TextBox();
            this.tb_tcno = new System.Windows.Forms.TextBox();
            this.lbl_adres = new System.Windows.Forms.Label();
            this.lbl_eposta = new System.Windows.Forms.Label();
            this.lbl_telno = new System.Windows.Forms.Label();
            this.lbl_adsoyad = new System.Windows.Forms.Label();
            this.lbl_tcno = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnexit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(173, 252);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.Location = new System.Drawing.Point(46, 252);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(75, 23);
            this.btn_guncelle.TabIndex = 15;
            this.btn_guncelle.Text = "Güncelle";
            this.btn_guncelle.UseVisualStyleBackColor = true;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // maskedtb_telno
            // 
            this.maskedtb_telno.Location = new System.Drawing.Point(115, 81);
            this.maskedtb_telno.Mask = "(999) 000-0000";
            this.maskedtb_telno.Name = "maskedtb_telno";
            this.maskedtb_telno.Size = new System.Drawing.Size(133, 20);
            this.maskedtb_telno.TabIndex = 13;
            // 
            // tb_adres
            // 
            this.tb_adres.Location = new System.Drawing.Point(115, 149);
            this.tb_adres.Multiline = true;
            this.tb_adres.Name = "tb_adres";
            this.tb_adres.Size = new System.Drawing.Size(133, 68);
            this.tb_adres.TabIndex = 9;
            // 
            // tb_eposta
            // 
            this.tb_eposta.Location = new System.Drawing.Point(115, 117);
            this.tb_eposta.Name = "tb_eposta";
            this.tb_eposta.Size = new System.Drawing.Size(133, 20);
            this.tb_eposta.TabIndex = 10;
            // 
            // tb_adsoyad
            // 
            this.tb_adsoyad.Location = new System.Drawing.Point(115, 50);
            this.tb_adsoyad.Name = "tb_adsoyad";
            this.tb_adsoyad.Size = new System.Drawing.Size(133, 20);
            this.tb_adsoyad.TabIndex = 11;
            // 
            // tb_tcno
            // 
            this.tb_tcno.Location = new System.Drawing.Point(115, 19);
            this.tb_tcno.Name = "tb_tcno";
            this.tb_tcno.Size = new System.Drawing.Size(133, 20);
            this.tb_tcno.TabIndex = 12;
            // 
            // lbl_adres
            // 
            this.lbl_adres.AutoSize = true;
            this.lbl_adres.Location = new System.Drawing.Point(28, 149);
            this.lbl_adres.Name = "lbl_adres";
            this.lbl_adres.Size = new System.Drawing.Size(40, 13);
            this.lbl_adres.TabIndex = 4;
            this.lbl_adres.Text = "Adres :";
            // 
            // lbl_eposta
            // 
            this.lbl_eposta.AutoSize = true;
            this.lbl_eposta.Location = new System.Drawing.Point(28, 120);
            this.lbl_eposta.Name = "lbl_eposta";
            this.lbl_eposta.Size = new System.Drawing.Size(49, 13);
            this.lbl_eposta.TabIndex = 5;
            this.lbl_eposta.Text = "E-posta :";
            // 
            // lbl_telno
            // 
            this.lbl_telno.AutoSize = true;
            this.lbl_telno.Location = new System.Drawing.Point(28, 88);
            this.lbl_telno.Name = "lbl_telno";
            this.lbl_telno.Size = new System.Drawing.Size(66, 13);
            this.lbl_telno.TabIndex = 6;
            this.lbl_telno.Text = "Telefon No :";
            // 
            // lbl_adsoyad
            // 
            this.lbl_adsoyad.AutoSize = true;
            this.lbl_adsoyad.Location = new System.Drawing.Point(28, 50);
            this.lbl_adsoyad.Name = "lbl_adsoyad";
            this.lbl_adsoyad.Size = new System.Drawing.Size(59, 13);
            this.lbl_adsoyad.TabIndex = 7;
            this.lbl_adsoyad.Text = "Ad Soyad :";
            // 
            // lbl_tcno
            // 
            this.lbl_tcno.AutoSize = true;
            this.lbl_tcno.Location = new System.Drawing.Point(28, 19);
            this.lbl_tcno.Name = "lbl_tcno";
            this.lbl_tcno.Size = new System.Drawing.Size(50, 13);
            this.lbl_tcno.TabIndex = 8;
            this.lbl_tcno.Text = "T.C. No :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(295, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(660, 316);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(46, 281);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(75, 23);
            this.btnexit.TabIndex = 15;
            this.btnexit.Text = "Çıkış";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // MusteriListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 340);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btn_guncelle);
            this.Controls.Add(this.maskedtb_telno);
            this.Controls.Add(this.tb_adres);
            this.Controls.Add(this.tb_eposta);
            this.Controls.Add(this.tb_adsoyad);
            this.Controls.Add(this.tb_tcno);
            this.Controls.Add(this.lbl_adres);
            this.Controls.Add(this.lbl_eposta);
            this.Controls.Add(this.lbl_telno);
            this.Controls.Add(this.lbl_adsoyad);
            this.Controls.Add(this.lbl_tcno);
            this.Name = "MusteriListele";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MusteriListele";
            this.Load += new System.EventHandler(this.MusteriListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.MaskedTextBox maskedtb_telno;
        private System.Windows.Forms.TextBox tb_adres;
        private System.Windows.Forms.TextBox tb_eposta;
        private System.Windows.Forms.TextBox tb_adsoyad;
        private System.Windows.Forms.TextBox tb_tcno;
        private System.Windows.Forms.Label lbl_adres;
        private System.Windows.Forms.Label lbl_eposta;
        private System.Windows.Forms.Label lbl_telno;
        private System.Windows.Forms.Label lbl_adsoyad;
        private System.Windows.Forms.Label lbl_tcno;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnexit;
    }
}