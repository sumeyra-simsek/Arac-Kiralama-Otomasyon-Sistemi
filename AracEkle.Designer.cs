namespace Arackiralamaproject
{
    partial class AracEkle
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
            this.lblplaka = new System.Windows.Forms.Label();
            this.lblmarka = new System.Windows.Forms.Label();
            this.lblseri = new System.Windows.Forms.Label();
            this.lblmodel = new System.Windows.Forms.Label();
            this.lblrenk = new System.Windows.Forms.Label();
            this.lblkm = new System.Windows.Forms.Label();
            this.lblyakit = new System.Windows.Forms.Label();
            this.lblkira = new System.Windows.Forms.Label();
            this.lbldurum = new System.Windows.Forms.Label();
            this.tbplaka = new System.Windows.Forms.TextBox();
            this.tbmodel = new System.Windows.Forms.TextBox();
            this.tbrenk = new System.Windows.Forms.TextBox();
            this.tbkira = new System.Windows.Forms.TextBox();
            this.cbmarka = new System.Windows.Forms.ComboBox();
            this.cbseri = new System.Windows.Forms.ComboBox();
            this.cbyakit = new System.Windows.Forms.ComboBox();
            this.cbdurum = new System.Windows.Forms.ComboBox();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.btncikis = new System.Windows.Forms.Button();
            this.tbkm = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblplaka
            // 
            this.lblplaka.AutoSize = true;
            this.lblplaka.Location = new System.Drawing.Point(37, 26);
            this.lblplaka.Name = "lblplaka";
            this.lblplaka.Size = new System.Drawing.Size(40, 13);
            this.lblplaka.TabIndex = 0;
            this.lblplaka.Text = "Plaka :";
            // 
            // lblmarka
            // 
            this.lblmarka.AutoSize = true;
            this.lblmarka.Location = new System.Drawing.Point(37, 56);
            this.lblmarka.Name = "lblmarka";
            this.lblmarka.Size = new System.Drawing.Size(43, 13);
            this.lblmarka.TabIndex = 0;
            this.lblmarka.Text = "Marka :";
            // 
            // lblseri
            // 
            this.lblseri.AutoSize = true;
            this.lblseri.Location = new System.Drawing.Point(37, 86);
            this.lblseri.Name = "lblseri";
            this.lblseri.Size = new System.Drawing.Size(31, 13);
            this.lblseri.TabIndex = 0;
            this.lblseri.Text = "Seri :";
            // 
            // lblmodel
            // 
            this.lblmodel.AutoSize = true;
            this.lblmodel.Location = new System.Drawing.Point(37, 114);
            this.lblmodel.Name = "lblmodel";
            this.lblmodel.Size = new System.Drawing.Size(57, 13);
            this.lblmodel.TabIndex = 0;
            this.lblmodel.Text = "Model(yıl) :";
            // 
            // lblrenk
            // 
            this.lblrenk.AutoSize = true;
            this.lblrenk.Location = new System.Drawing.Point(37, 152);
            this.lblrenk.Name = "lblrenk";
            this.lblrenk.Size = new System.Drawing.Size(39, 13);
            this.lblrenk.TabIndex = 0;
            this.lblrenk.Text = "Renk :";
            // 
            // lblkm
            // 
            this.lblkm.AutoSize = true;
            this.lblkm.Location = new System.Drawing.Point(37, 185);
            this.lblkm.Name = "lblkm";
            this.lblkm.Size = new System.Drawing.Size(56, 13);
            this.lblkm.TabIndex = 0;
            this.lblkm.Text = "Kilometre :";
            // 
            // lblyakit
            // 
            this.lblyakit.AutoSize = true;
            this.lblyakit.Location = new System.Drawing.Point(37, 224);
            this.lblyakit.Name = "lblyakit";
            this.lblyakit.Size = new System.Drawing.Size(37, 13);
            this.lblyakit.TabIndex = 0;
            this.lblyakit.Text = "Yakıt :";
            // 
            // lblkira
            // 
            this.lblkira.AutoSize = true;
            this.lblkira.Location = new System.Drawing.Point(37, 267);
            this.lblkira.Name = "lblkira";
            this.lblkira.Size = new System.Drawing.Size(62, 13);
            this.lblkira.TabIndex = 0;
            this.lblkira.Text = "Kira Ücreti :";
            // 
            // lbldurum
            // 
            this.lbldurum.AutoSize = true;
            this.lbldurum.Location = new System.Drawing.Point(37, 302);
            this.lbldurum.Name = "lbldurum";
            this.lbldurum.Size = new System.Drawing.Size(50, 13);
            this.lbldurum.TabIndex = 0;
            this.lbldurum.Text = "Durumu :";
            // 
            // tbplaka
            // 
            this.tbplaka.Location = new System.Drawing.Point(110, 23);
            this.tbplaka.Name = "tbplaka";
            this.tbplaka.Size = new System.Drawing.Size(121, 20);
            this.tbplaka.TabIndex = 1;
            // 
            // tbmodel
            // 
            this.tbmodel.Location = new System.Drawing.Point(110, 111);
            this.tbmodel.Name = "tbmodel";
            this.tbmodel.Size = new System.Drawing.Size(121, 20);
            this.tbmodel.TabIndex = 1;
            // 
            // tbrenk
            // 
            this.tbrenk.Location = new System.Drawing.Point(110, 149);
            this.tbrenk.Name = "tbrenk";
            this.tbrenk.Size = new System.Drawing.Size(121, 20);
            this.tbrenk.TabIndex = 1;
            // 
            // tbkira
            // 
            this.tbkira.Location = new System.Drawing.Point(110, 267);
            this.tbkira.Name = "tbkira";
            this.tbkira.Size = new System.Drawing.Size(121, 20);
            this.tbkira.TabIndex = 1;
            // 
            // cbmarka
            // 
            this.cbmarka.FormattingEnabled = true;
            this.cbmarka.Items.AddRange(new object[] {
            "Bmw",
            "Mercedes",
            "Tofaş",
            "Dacia"});
            this.cbmarka.Location = new System.Drawing.Point(110, 53);
            this.cbmarka.Name = "cbmarka";
            this.cbmarka.Size = new System.Drawing.Size(121, 21);
            this.cbmarka.TabIndex = 2;
            this.cbmarka.SelectedIndexChanged += new System.EventHandler(this.cbmarka_SelectedIndexChanged);
            // 
            // cbseri
            // 
            this.cbseri.FormattingEnabled = true;
            this.cbseri.Location = new System.Drawing.Point(110, 83);
            this.cbseri.Name = "cbseri";
            this.cbseri.Size = new System.Drawing.Size(121, 21);
            this.cbseri.TabIndex = 2;
            // 
            // cbyakit
            // 
            this.cbyakit.FormattingEnabled = true;
            this.cbyakit.Items.AddRange(new object[] {
            "Benzin",
            "Dizel",
            "LPG",
            "Benzin/LPG"});
            this.cbyakit.Location = new System.Drawing.Point(110, 224);
            this.cbyakit.Name = "cbyakit";
            this.cbyakit.Size = new System.Drawing.Size(121, 21);
            this.cbyakit.TabIndex = 2;
            // 
            // cbdurum
            // 
            this.cbdurum.FormattingEnabled = true;
            this.cbdurum.Items.AddRange(new object[] {
            "Boş",
            "Dolu"});
            this.cbdurum.Location = new System.Drawing.Point(110, 302);
            this.cbdurum.Name = "cbdurum";
            this.cbdurum.Size = new System.Drawing.Size(121, 21);
            this.cbdurum.TabIndex = 2;
            // 
            // btnkaydet
            // 
            this.btnkaydet.Location = new System.Drawing.Point(40, 346);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(89, 28);
            this.btnkaydet.TabIndex = 3;
            this.btnkaydet.Text = "Kaydet";
            this.btnkaydet.UseVisualStyleBackColor = true;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // btncikis
            // 
            this.btncikis.Location = new System.Drawing.Point(142, 346);
            this.btncikis.Name = "btncikis";
            this.btncikis.Size = new System.Drawing.Size(89, 28);
            this.btncikis.TabIndex = 3;
            this.btncikis.Text = "Çıkış";
            this.btncikis.UseVisualStyleBackColor = true;
            this.btncikis.Click += new System.EventHandler(this.btncikis_Click);
            // 
            // tbkm
            // 
            this.tbkm.Location = new System.Drawing.Point(110, 182);
            this.tbkm.Name = "tbkm";
            this.tbkm.Size = new System.Drawing.Size(121, 20);
            this.tbkm.TabIndex = 1;
            // 
            // AracEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 403);
            this.Controls.Add(this.btncikis);
            this.Controls.Add(this.btnkaydet);
            this.Controls.Add(this.cbdurum);
            this.Controls.Add(this.cbyakit);
            this.Controls.Add(this.cbseri);
            this.Controls.Add(this.cbmarka);
            this.Controls.Add(this.tbkira);
            this.Controls.Add(this.tbkm);
            this.Controls.Add(this.tbrenk);
            this.Controls.Add(this.tbmodel);
            this.Controls.Add(this.tbplaka);
            this.Controls.Add(this.lbldurum);
            this.Controls.Add(this.lblkira);
            this.Controls.Add(this.lblyakit);
            this.Controls.Add(this.lblkm);
            this.Controls.Add(this.lblrenk);
            this.Controls.Add(this.lblmodel);
            this.Controls.Add(this.lblseri);
            this.Controls.Add(this.lblmarka);
            this.Controls.Add(this.lblplaka);
            this.Name = "AracEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AracEkle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblplaka;
        private System.Windows.Forms.Label lblmarka;
        private System.Windows.Forms.Label lblseri;
        private System.Windows.Forms.Label lblmodel;
        private System.Windows.Forms.Label lblrenk;
        private System.Windows.Forms.Label lblkm;
        private System.Windows.Forms.Label lblyakit;
        private System.Windows.Forms.Label lblkira;
        private System.Windows.Forms.Label lbldurum;
        private System.Windows.Forms.TextBox tbplaka;
        private System.Windows.Forms.TextBox tbmodel;
        private System.Windows.Forms.TextBox tbrenk;
        private System.Windows.Forms.TextBox tbkira;
        private System.Windows.Forms.ComboBox cbmarka;
        private System.Windows.Forms.ComboBox cbseri;
        private System.Windows.Forms.ComboBox cbyakit;
        private System.Windows.Forms.ComboBox cbdurum;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.Button btncikis;
        private System.Windows.Forms.TextBox tbkm;
    }
}