using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AskerlikKontrol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text = "Askerlik Yaptığınız Gün:";
            button1.Text = "Hesapla";
            label2.Text = "Sonuç";            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int gun = Convert.ToInt32(textBox1.Text);

            if (gun == 180)
            {
                label2.Text = "Askerliğiniz Bitti Tezkereniz Hayırlı Olsun";
            }
            else if (gun < 180)
            {
                label2.Text = "Askerliğnizin Bitmesine " + Convert.ToString(180 - gun) + " Gün Kalmıştır.";
            }
            else
            {
                label2.Text = "Fazla Gün Girilmiştir.";
            }
        }

    }
}
