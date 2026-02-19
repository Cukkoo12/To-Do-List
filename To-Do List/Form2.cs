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
            HesaplariListele();
        }
        private void HesaplariListele()
        {
            hesapListesi.Items.Clear();
            string[] dosyalar = Directory.GetFiles(Directory.GetCurrentDirectory(), "*_sifre.txt");
            foreach (string dosya in dosyalar)
            {
                FileInfo dosyaFile = new FileInfo(dosya);
                string kullaniciAdi = dosyaFile.Name.Replace("_sifre.txt", "");
                hesapListesi.Items.Add(kullaniciAdi);
            }
        }
        private void giris_Click(object sender, EventArgs e)
        {
            bool girisBasarili = false;
            if (File.Exists(kullaniciAdi.Text + "_sifre.txt"))
            {
                string[] kayitlar = File.ReadAllLines(kullaniciAdi.Text + "_sifre.txt");
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
            if (girisBasarili)
            {
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
                string kayitVerisi = kullaniciAdi.Text + "|" + sifre.Text + "\n";
                File.AppendAllLines(kullaniciAdi.Text + "_sifre.txt", new[] { kayitVerisi });
                MessageBox.Show("Kayıt başarılı! Artık giriş yapabilirsiniz.");
                HesaplariListele();
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
            if (e.KeyCode == Keys.Enter)
            {
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

        private void hesapSil_Click(object sender, EventArgs e)
        {
            if (hesapListesi.SelectedIndex != -1 && sifre.Text != "")
            {
                string secilenKullanici = hesapListesi.SelectedItem.ToString();
                string sifreDosyasi = secilenKullanici + "_sifre.txt";
                string listeDosyasi = secilenKullanici + "_liste.txt";
                bool sifreDogru = false;
                if (File.Exists(sifreDosyasi))
                {
                    string[] kayitlar = File.ReadAllLines(sifreDosyasi);
                    foreach (string kayit in kayitlar)
                    {
                        string[] parcalar = kayit.Split('|');
                        if (parcalar.Length == 2 && parcalar[0] == secilenKullanici && parcalar[1] == sifre.Text)
                        {
                            sifreDogru = true;
                            break;
                        }
                    }
                }
                if (sifreDogru)
                {
                    File.Delete(sifreDosyasi);
                    if (File.Exists(listeDosyasi))
                    {
                        File.Delete(listeDosyasi);
                    }
                    MessageBox.Show("Hesap başarıyla silindi.");
                    HesaplariListele();
                }
                else
                {
                    MessageBox.Show("Şifre yanlış. Hesap silinemedi.");
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz hesabı seçiniz ve şifresini giriniz.");
            }
        }
    }
}