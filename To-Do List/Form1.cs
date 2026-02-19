using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace To_Do_List
{
    public partial class Form1 : Form
    {
        string dosyayolu;
        public Form1(string girenKullanici)
        {
            InitializeComponent();
            dosyayolu = $"{girenKullanici}.txt";
            this.Text = "To-Do List - Aktif Kullanıcı:" + girenKullanici;
            verileriyukle();
        }
        private void verilerikaydet()
        {
            List<string> metinler = new List<string>();
            foreach (var item in liste.Items)
            {
                metinler.Add(item.ToString());
            }
            File.WriteAllLines(dosyayolu, metinler);
        }
        private void verileriyukle()
        {
            if (File.Exists(dosyayolu))
            {
                string[] metinler = File.ReadAllLines(dosyayolu);
                liste.Items.AddRange(metinler);
            }
        }
        private void ekle_Click(object sender, EventArgs e)
        {
            string metinyazısı = metin.Text;
            if (metinyazısı != "")
            {
                liste.Items.Add(metinyazısı);
                metin.Clear();
                metin.Focus();
                verilerikaydet();
            }
            else
            {
                MessageBox.Show("Lütfen bir metin giriniz.");
            }

        }

        private void sil_Click(object sender, EventArgs e)
        {
            if (liste.SelectedIndex != -1)
            {
                liste.Items.RemoveAt(liste.SelectedIndex);
                verilerikaydet();
                if (liste.Items.Count == 0)
                {
                    MessageBox.Show("Liste boş.");
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz öğeyi seçiniz.");
            }
        }

        private void temizle_Click(object sender, EventArgs e)
        {
            for (int i = liste.Items.Count-1; i >=0; i--)
            {
                if (liste.GetItemChecked(i) == true)
                {
                    liste.Items.RemoveAt(i);
                }
            }
            if (liste.Items.Count == 0)
            {
                MessageBox.Show("Liste boş.");
            }
            verilerikaydet();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            saat.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
