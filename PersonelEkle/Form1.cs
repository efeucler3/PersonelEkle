using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonelEkle
{
    public partial class Form1 : Form
    {
        Personel p = new Personel();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            p.SicilNo = textBox1.Text;
            p.ad = textBox2.Text;
            p.soyad = textBox3.Text;
            p.maas = textBox4.Text;
            p.birim = comboBox1.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label7.Text = p.SicilNo;
            label8.Text = p.ad;
            label9.Text = p.soyad;
            label10.Text = p.birim;
            label11.Text = p.maas;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            p.SicilNo = textBox1.Text;
            p.ad = textBox2.Text;
            p.soyad = textBox3.Text;
            p.maas = textBox4.Text;
            p.birim = comboBox1.Text;
            MessageBox.Show("Bilgiler güncellendi lütfen listeleye basın");
        }
    }
}
