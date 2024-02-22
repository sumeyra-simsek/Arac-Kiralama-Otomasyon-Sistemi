namespace Arackiralamaproject
{
    partial class form_anasayfa
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
            this.btn_müsteriekle = new System.Windows.Forms.Button();
            this.btn_aracekle = new System.Windows.Forms.Button();
            this.btn_müsterilistele = new System.Windows.Forms.Button();
            this.btn_araclistele = new System.Windows.Forms.Button();
            this.btn_sozlesme = new System.Windows.Forms.Button();
            this.btn_satislar = new System.Windows.Forms.Button();
            this.btn_cikis = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_müsteriekle
            // 
            this.btn_müsteriekle.Location = new System.Drawing.Point(692, 33);
            this.btn_müsteriekle.Name = "btn_müsteriekle";
            this.btn_müsteriekle.Size = new System.Drawing.Size(75, 40);
            this.btn_müsteriekle.TabIndex = 1;
            this.btn_müsteriekle.Text = "Müşteri Ekle";
            this.btn_müsteriekle.UseVisualStyleBackColor = true;
            this.btn_müsteriekle.Click += new System.EventHandler(this.btn_müsteriekle_Click);
            // 
            // btn_aracekle
            // 
            this.btn_aracekle.Location = new System.Drawing.Point(692, 165);
            this.btn_aracekle.Name = "btn_aracekle";
            this.btn_aracekle.Size = new System.Drawing.Size(75, 40);
            this.btn_aracekle.TabIndex = 1;
            this.btn_aracekle.Text = "Araç Ekle";
            this.btn_aracekle.UseVisualStyleBackColor = true;
            this.btn_aracekle.Click += new System.EventHandler(this.btn_aracekle_Click);
            // 
            // btn_müsterilistele
            // 
            this.btn_müsterilistele.Location = new System.Drawing.Point(692, 99);
            this.btn_müsterilistele.Name = "btn_müsterilistele";
            this.btn_müsterilistele.Size = new System.Drawing.Size(75, 40);
            this.btn_müsterilistele.TabIndex = 1;
            this.btn_müsterilistele.Text = "Müşteri Listele";
            this.btn_müsterilistele.UseVisualStyleBackColor = true;
            this.btn_müsterilistele.Click += new System.EventHandler(this.btn_müsterilistele_Click);
            // 
            // btn_araclistele
            // 
            this.btn_araclistele.Location = new System.Drawing.Point(692, 239);
            this.btn_araclistele.Name = "btn_araclistele";
            this.btn_araclistele.Size = new System.Drawing.Size(75, 40);
            this.btn_araclistele.TabIndex = 1;
            this.btn_araclistele.Text = "Araç listele";
            this.btn_araclistele.UseVisualStyleBackColor = true;
            this.btn_araclistele.Click += new System.EventHandler(this.btn_araclistele_Click);
            // 
            // btn_sozlesme
            // 
            this.btn_sozlesme.Location = new System.Drawing.Point(692, 305);
            this.btn_sozlesme.Name = "btn_sozlesme";
            this.btn_sozlesme.Size = new System.Drawing.Size(75, 40);
            this.btn_sozlesme.TabIndex = 1;
            this.btn_sozlesme.Text = "Sözleşme";
            this.btn_sozlesme.UseVisualStyleBackColor = true;
            this.btn_sozlesme.Click += new System.EventHandler(this.btn_sozlesme_Click);
            // 
            // btn_satislar
            // 
            this.btn_satislar.Location = new System.Drawing.Point(692, 377);
            this.btn_satislar.Name = "btn_satislar";
            this.btn_satislar.Size = new System.Drawing.Size(75, 40);
            this.btn_satislar.TabIndex = 1;
            this.btn_satislar.Text = "Satışlar";
            this.btn_satislar.UseVisualStyleBackColor = true;
            this.btn_satislar.Click += new System.EventHandler(this.btn_satislar_Click);
            // 
            // btn_cikis
            // 
            this.btn_cikis.Location = new System.Drawing.Point(692, 451);
            this.btn_cikis.Name = "btn_cikis";
            this.btn_cikis.Size = new System.Drawing.Size(75, 40);
            this.btn_cikis.TabIndex = 1;
            this.btn_cikis.Text = "Çıkış";
            this.btn_cikis.UseVisualStyleBackColor = true;
            this.btn_cikis.Click += new System.EventHandler(this.btn_cikis_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Arackiralamaproject.Properties.Resources.arkaplan_640x513;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(637, 507);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // form_anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 542);
            this.Controls.Add(this.btn_satislar);
            this.Controls.Add(this.btn_araclistele);
            this.Controls.Add(this.btn_aracekle);
            this.Controls.Add(this.btn_cikis);
            this.Controls.Add(this.btn_sozlesme);
            this.Controls.Add(this.btn_müsterilistele);
            this.Controls.Add(this.btn_müsteriekle);
            this.Controls.Add(this.pictureBox1);
            this.Name = "form_anasayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Sayfa";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_müsteriekle;
        private System.Windows.Forms.Button btn_aracekle;
        private System.Windows.Forms.Button btn_müsterilistele;
        private System.Windows.Forms.Button btn_araclistele;
        private System.Windows.Forms.Button btn_sozlesme;
        private System.Windows.Forms.Button btn_satislar;
        private System.Windows.Forms.Button btn_cikis;
    }
}

