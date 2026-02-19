using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace To_Do_List
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void giris_Click(object sender, EventArgs e)
        {
            if (kullaniciAdi.Text == "admin" && sifre.Text == "1234")
            {
                Form1 anaPencere = new Form1();
                anaPencere.Show();
                anaPencere.FormClosed += (s, args) => this.Close();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre yanlış.");
                kullaniciAdi.Clear();
                sifre.Clear();
                kullaniciAdi.Focus();
            }
        }

        private void sifre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                giris_Click(sender, e);
            }
        }

        private void kullaniciAdi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                e.SuppressKeyPress = true;
                giris_Click(sender, e);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                sifre.UseSystemPasswordChar = false;
            }
            else
            {
                sifre.UseSystemPasswordChar = true;
            }
        }
    }
}
