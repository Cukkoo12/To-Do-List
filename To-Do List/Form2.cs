using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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
            bool girisBasarili = false;
            if (File.Exists(kullaniciAdi.Text + ".txt"))
            {
                string[] kayitlar = File.ReadAllLines(kullaniciAdi.Text + ".txt");
                foreach (string kayit in kayitlar)
                {
                    string[] parcalar = kayit.Split('|');
                    if (parcalar.Length == 2 && parcalar[0] == kullaniciAdi.Text && parcalar[1] == sifre.Text)
                    {
                        girisBasarili = true;
                        break;
                    }
                }
            }
            if (girisBasarili) {
                Form1 form1 = new Form1(kullaniciAdi.Text);
                form1.Show();
                form1.FormClosed += (s, args) => this.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre yanlış. Lütfen tekrar deneyiniz.");
            }
        }
        private void kayitOl_Click(object sender, EventArgs e)
        {
            if (kullaniciAdi.Text != "" && sifre.Text != "")
            {
                string kayitVerisi = kullaniciAdi.Text +"|"+sifre.Text+"\n";
                File.AppendAllLines(kullaniciAdi.Text + ".txt", new[] { kayitVerisi });
                MessageBox.Show("Kayıt başarılı! Artık giriş yapabilirsiniz.");
            }
            else
            {
                MessageBox.Show("Lütfen kullanıcı adı ve şifre giriniz.");
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
