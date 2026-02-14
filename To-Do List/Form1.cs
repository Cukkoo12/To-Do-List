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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ekle_Click(object sender, EventArgs e)
        {
            string metinyazısı = metin.Text;
            if (metinyazısı != "")
            {
                liste.Items.Add(metinyazısı);
                metin.Clear();
                metin.Focus();
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
    }
}
