namespace To_Do_List
{
    partial class Form2
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
            this.kullaniciAdi = new System.Windows.Forms.TextBox();
            this.sifre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.giris = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.kayıt = new System.Windows.Forms.Button();
            this.hesapListesi = new System.Windows.Forms.ComboBox();
            this.hesapSil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // kullaniciAdi
            // 
            this.kullaniciAdi.Location = new System.Drawing.Point(108, 229);
            this.kullaniciAdi.Name = "kullaniciAdi";
            this.kullaniciAdi.Size = new System.Drawing.Size(194, 22);
            this.kullaniciAdi.TabIndex = 0;
            this.kullaniciAdi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.kullaniciAdi_KeyDown);
            // 
            // sifre
            // 
            this.sifre.Location = new System.Drawing.Point(108, 257);
            this.sifre.Name = "sifre";
            this.sifre.Size = new System.Drawing.Size(194, 22);
            this.sifre.TabIndex = 1;
            this.sifre.UseSystemPasswordChar = true;
            this.sifre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.sifre_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre";
            // 
            // giris
            // 
            this.giris.Location = new System.Drawing.Point(227, 285);
            this.giris.Name = "giris";
            this.giris.Size = new System.Drawing.Size(75, 23);
            this.giris.TabIndex = 2;
            this.giris.Text = "Giriş Yap";
            this.giris.UseVisualStyleBackColor = true;
            this.giris.Click += new System.EventHandler(this.giris_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(308, 259);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(103, 20);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Göster/Gizle";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // kayıt
            // 
            this.kayıt.Location = new System.Drawing.Point(108, 285);
            this.kayıt.Name = "kayıt";
            this.kayıt.Size = new System.Drawing.Size(75, 23);
            this.kayıt.TabIndex = 2;
            this.kayıt.Text = "Kayıt Ol";
            this.kayıt.UseVisualStyleBackColor = true;
            this.kayıt.Click += new System.EventHandler(this.kayitOl_Click);
            // 
            // hesapListesi
            // 
            this.hesapListesi.FormattingEnabled = true;
            this.hesapListesi.Location = new System.Drawing.Point(108, 314);
            this.hesapListesi.Name = "hesapListesi";
            this.hesapListesi.Size = new System.Drawing.Size(194, 24);
            this.hesapListesi.TabIndex = 4;
            // 
            // hesapSil
            // 
            this.hesapSil.Location = new System.Drawing.Point(308, 315);
            this.hesapSil.Name = "hesapSil";
            this.hesapSil.Size = new System.Drawing.Size(75, 23);
            this.hesapSil.TabIndex = 5;
            this.hesapSil.Text = "Hesap Sil";
            this.hesapSil.UseVisualStyleBackColor = true;
            this.hesapSil.Click += new System.EventHandler(this.hesapSil_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 605);
            this.Controls.Add(this.hesapSil);
            this.Controls.Add(this.hesapListesi);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.kayıt);
            this.Controls.Add(this.giris);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sifre);
            this.Controls.Add(this.kullaniciAdi);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox kullaniciAdi;
        private System.Windows.Forms.TextBox sifre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button giris;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button kayıt;
        private System.Windows.Forms.ComboBox hesapListesi;
        private System.Windows.Forms.Button hesapSil;
    }
}