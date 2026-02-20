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
            this.metin.Location = new System.Drawing.Point(14, 515);
            this.metin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.metin.Name = "metin";
            this.metin.Size = new System.Drawing.Size(357, 30);
            this.metin.TabIndex = 1;
            // 
            // ekle
            // 
            this.ekle.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ekle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ekle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ekle.ForeColor = System.Drawing.Color.White;
            this.ekle.Location = new System.Drawing.Point(14, 555);
            this.ekle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ekle.Name = "ekle";
            this.ekle.Size = new System.Drawing.Size(147, 33);
            this.ekle.TabIndex = 2;
            this.ekle.Text = "Ekle";
            this.ekle.UseVisualStyleBackColor = false;
            this.ekle.Click += new System.EventHandler(this.ekle_Click);
            // 
            // sil
            // 
            this.sil.BackColor = System.Drawing.Color.Crimson;
            this.sil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sil.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sil.ForeColor = System.Drawing.Color.White;
            this.sil.Location = new System.Drawing.Point(224, 555);
            this.sil.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sil.Name = "sil";
            this.sil.Size = new System.Drawing.Size(147, 33);
            this.sil.TabIndex = 2;
            this.sil.Text = "Sil";
            this.sil.UseVisualStyleBackColor = false;
            this.sil.Click += new System.EventHandler(this.sil_Click);
            // 
            // liste
            // 
            this.liste.FormattingEnabled = true;
            this.liste.Location = new System.Drawing.Point(4, 17);
            this.liste.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.liste.Name = "liste";
            this.liste.Size = new System.Drawing.Size(366, 479);
            this.liste.TabIndex = 3;
            // 
            // temizle
            // 
            this.temizle.BackColor = System.Drawing.Color.Goldenrod;
            this.temizle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.temizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.temizle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.temizle.ForeColor = System.Drawing.Color.White;
            this.temizle.Location = new System.Drawing.Point(112, 597);
            this.temizle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.temizle.Name = "temizle";
            this.temizle.Size = new System.Drawing.Size(146, 33);
            this.temizle.TabIndex = 4;
            this.temizle.Text = "Temizle";
            this.temizle.UseVisualStyleBackColor = false;
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
            this.saat.Location = new System.Drawing.Point(699, 13);
            this.saat.Name = "saat";
            this.saat.Size = new System.Drawing.Size(91, 39);
            this.saat.TabIndex = 5;
            this.saat.Text = "Saat";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(900, 647);
            this.Controls.Add(this.saat);
            this.Controls.Add(this.temizle);
            this.Controls.Add(this.liste);
            this.Controls.Add(this.sil);
            this.Controls.Add(this.ekle);
            this.Controls.Add(this.metin);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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

