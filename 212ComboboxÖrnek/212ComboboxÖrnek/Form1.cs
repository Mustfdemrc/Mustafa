using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _212ComboboxÖrnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Text = "Hesapla";
            comboBox1.Items.Add("Topla");
            comboBox1.Items.Add("Çıkar");
            comboBox1.Items.Add("Çarp");
            comboBox1.Items.Add("Böl");
            comboBox1.SelectedIndex = 0;
            label1.Text = "Sayı 1";
            label2.Text = "Sayı 2";
            label3.Text = "Sonuç;";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            int sonuc = 0;
            if (comboBox1.SelectedIndex == 0)
            {
                sonuc = a + b;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                sonuc = a - b;
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                sonuc = a * b;
            }
            else if (comboBox1.SelectedIndex == 3 || b !=0)
            {
              
                sonuc = a / b;
            }
            
            label3.Text = Convert.ToString(sonuc);
        }
    }
}
