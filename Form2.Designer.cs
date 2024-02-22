namespace Arackiralamaproject
{
    partial class form_musteriekle
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
            this.lbl_tcno = new System.Windows.Forms.Label();
            this.lbl_adsoyad = new System.Windows.Forms.Label();
            this.lbl_telno = new System.Windows.Forms.Label();
            this.lbl_eposta = new System.Windows.Forms.Label();
            this.lbl_adres = new System.Windows.Forms.Label();
            this.tb_tcno = new System.Windows.Forms.TextBox();
            this.tb_adsoyad = new System.Windows.Forms.TextBox();
            this.tb_eposta = new System.Windows.Forms.TextBox();
            this.tb_adres = new System.Windows.Forms.TextBox();
            this.maskedtb_telno = new System.Windows.Forms.MaskedTextBox();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.btn_cikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_tcno
            // 
            this.lbl_tcno.AutoSize = true;
            this.lbl_tcno.Location = new System.Drawing.Point(34, 18);
            this.lbl_tcno.Name = "lbl_tcno";
            this.lbl_tcno.Size = new System.Drawing.Size(50, 13);
            this.lbl_tcno.TabIndex = 0;
            this.lbl_tcno.Text = "T.C. No :";
            // 
            // lbl_adsoyad
            // 
            this.lbl_adsoyad.AutoSize = true;
            this.lbl_adsoyad.Location = new System.Drawing.Point(34, 49);
            this.lbl_adsoyad.Name = "lbl_adsoyad";
            this.lbl_adsoyad.Size = new System.Drawing.Size(59, 13);
            this.lbl_adsoyad.TabIndex = 0;
            this.lbl_adsoyad.Text = "Ad Soyad :";
            // 
            // lbl_telno
            // 
            this.lbl_telno.AutoSize = true;
            this.lbl_telno.Location = new System.Drawing.Point(34, 87);
            this.lbl_telno.Name = "lbl_telno";
            this.lbl_telno.Size = new System.Drawing.Size(66, 13);
            this.lbl_telno.TabIndex = 0;
            this.lbl_telno.Text = "Telefon No :";
            // 
            // lbl_eposta
            // 
            this.lbl_eposta.AutoSize = true;
            this.lbl_eposta.Location = new System.Drawing.Point(34, 119);
            this.lbl_eposta.Name = "lbl_eposta";
            this.lbl_eposta.Size = new System.Drawing.Size(49, 13);
            this.lbl_eposta.TabIndex = 0;
            this.lbl_eposta.Text = "E-posta :";
            // 
            // lbl_adres
            // 
            this.lbl_adres.AutoSize = true;
            this.lbl_adres.Location = new System.Drawing.Point(34, 148);
            this.lbl_adres.Name = "lbl_adres";
            this.lbl_adres.Size = new System.Drawing.Size(40, 13);
            this.lbl_adres.TabIndex = 0;
            this.lbl_adres.Text = "Adres :";
            // 
            // tb_tcno
            // 
            this.tb_tcno.Location = new System.Drawing.Point(121, 18);
            this.tb_tcno.Name = "tb_tcno";
            this.tb_tcno.Size = new System.Drawing.Size(133, 20);
            this.tb_tcno.TabIndex = 1;
            // 
            // tb_adsoyad
            // 
            this.tb_adsoyad.Location = new System.Drawing.Point(121, 49);
            this.tb_adsoyad.Name = "tb_adsoyad";
            this.tb_adsoyad.Size = new System.Drawing.Size(133, 20);
            this.tb_adsoyad.TabIndex = 1;
            // 
            // tb_eposta
            // 
            this.tb_eposta.Location = new System.Drawing.Point(121, 116);
            this.tb_eposta.Name = "tb_eposta";
            this.tb_eposta.Size = new System.Drawing.Size(254, 20);
            this.tb_eposta.TabIndex = 1;
            // 
            // tb_adres
            // 
            this.tb_adres.Location = new System.Drawing.Point(121, 148);
            this.tb_adres.Multiline = true;
            this.tb_adres.Name = "tb_adres";
            this.tb_adres.Size = new System.Drawing.Size(254, 68);
            this.tb_adres.TabIndex = 1;
            // 
            // maskedtb_telno
            // 
            this.maskedtb_telno.Location = new System.Drawing.Point(121, 80);
            this.maskedtb_telno.Mask = "(999) 000-0000";
            this.maskedtb_telno.Name = "maskedtb_telno";
            this.maskedtb_telno.Size = new System.Drawing.Size(133, 20);
            this.maskedtb_telno.TabIndex = 2;
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Location = new System.Drawing.Point(134, 266);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(75, 53);
            this.btn_kaydet.TabIndex = 3;
            this.btn_kaydet.Text = "Kaydet";
            this.btn_kaydet.UseVisualStyleBackColor = true;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // btn_cikis
            // 
            this.btn_cikis.Location = new System.Drawing.Point(282, 266);
            this.btn_cikis.Name = "btn_cikis";
            this.btn_cikis.Size = new System.Drawing.Size(75, 53);
            this.btn_cikis.TabIndex = 3;
            this.btn_cikis.Text = "Çıkış";
            this.btn_cikis.UseVisualStyleBackColor = true;
            this.btn_cikis.Click += new System.EventHandler(this.btn_cikis_Click);
            // 
            // form_musteriekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 357);
            this.Controls.Add(this.btn_cikis);
            this.Controls.Add(this.btn_kaydet);
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
            this.Name = "form_musteriekle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteri Ekle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_tcno;
        private System.Windows.Forms.Label lbl_adsoyad;
        private System.Windows.Forms.Label lbl_telno;
        private System.Windows.Forms.Label lbl_eposta;
        private System.Windows.Forms.Label lbl_adres;
        private System.Windows.Forms.TextBox tb_tcno;
        private System.Windows.Forms.TextBox tb_adsoyad;
        private System.Windows.Forms.TextBox tb_eposta;
        private System.Windows.Forms.TextBox tb_adres;
        private System.Windows.Forms.MaskedTextBox maskedtb_telno;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.Button btn_cikis;
    }
}