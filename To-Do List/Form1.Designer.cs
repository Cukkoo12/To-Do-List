namespace To_Do_List
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
            this.components = new System.ComponentModel.Container();
            this.metin = new System.Windows.Forms.TextBox();
            this.ekle = new System.Windows.Forms.Button();
            this.sil = new System.Windows.Forms.Button();
            this.liste = new System.Windows.Forms.CheckedListBox();
            this.temizle = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.saat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // metin
            // 
            this.metin.Location = new System.Drawing.Point(12, 358);
            this.metin.Name = "metin";
            this.metin.Size = new System.Drawing.Size(318, 22);
            this.metin.TabIndex = 1;
            // 
            // ekle
            // 
            this.ekle.Location = new System.Drawing.Point(12, 386);
            this.ekle.Name = "ekle";
            this.ekle.Size = new System.Drawing.Size(131, 23);
            this.ekle.TabIndex = 2;
            this.ekle.Text = "Ekle";
            this.ekle.UseVisualStyleBackColor = true;
            this.ekle.Click += new System.EventHandler(this.ekle_Click);
            // 
            // sil
            // 
            this.sil.Location = new System.Drawing.Point(199, 386);
            this.sil.Name = "sil";
            this.sil.Size = new System.Drawing.Size(131, 23);
            this.sil.TabIndex = 2;
            this.sil.Text = "Sil";
            this.sil.UseVisualStyleBackColor = true;
            this.sil.Click += new System.EventHandler(this.sil_Click);
            // 
            // liste
            // 
            this.liste.FormattingEnabled = true;
            this.liste.Location = new System.Drawing.Point(4, 12);
            this.liste.Name = "liste";
            this.liste.Size = new System.Drawing.Size(326, 344);
            this.liste.TabIndex = 3;
            // 
            // temizle
            // 
            this.temizle.Location = new System.Drawing.Point(100, 415);
            this.temizle.Name = "temizle";
            this.temizle.Size = new System.Drawing.Size(130, 23);
            this.temizle.TabIndex = 4;
            this.temizle.Text = "Temizle";
            this.temizle.UseVisualStyleBackColor = true;
            this.temizle.Click += new System.EventHandler(this.temizle_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // saat
            // 
            this.saat.AutoSize = true;
            this.saat.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.saat.Location = new System.Drawing.Point(621, 9);
            this.saat.Name = "saat";
            this.saat.Size = new System.Drawing.Size(91, 39);
            this.saat.TabIndex = 5;
            this.saat.Text = "Saat";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.saat);
            this.Controls.Add(this.temizle);
            this.Controls.Add(this.liste);
            this.Controls.Add(this.sil);
            this.Controls.Add(this.ekle);
            this.Controls.Add(this.metin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox metin;
        private System.Windows.Forms.Button ekle;
        private System.Windows.Forms.Button sil;
        private System.Windows.Forms.CheckedListBox liste;
        private System.Windows.Forms.Button temizle;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label saat;
    }
}

