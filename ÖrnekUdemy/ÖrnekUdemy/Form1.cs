using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ÖrnekUdemy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text = "Ad:";
            label2.Text = "Soyad:";
            label3.Text = "Öğreci No:";
            label4.Text = "1.Sınav";
            label5.Text = "2.Sınav:";
            label6.Text = "Proje Notu:";
            button1.Text = "Hesapla";               
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad, soyad, no;
            int s1, s2, proje;
            double ort;
            ad = textBox1.Text;
            soyad= textBox2.Text;
            no = textBox3.Text;
            s1=Convert.ToInt32(textBox4.Text);
            s2=Convert.ToInt32(textBox5.Text);
            proje=Convert.ToInt32(textBox6.Text);
            ort = (s1 + s2 + proje) / 3;
            listBox1.Items.Add(ad + " " + soyad + " " + no + " Ortalama:" + ort);

        }
    }
}
