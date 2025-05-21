using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UdemyDers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            groupBox1.Text = "Ürün Miktarı";
            label1.Text = "Mısır";
            label2.Text = "Su";
            label3.Text = "İçecek";
            label4.Text = "Bilet";
            groupBox2.Text = "Fiyat Tablosu";
            label5.Text = "Mısır = 70 TL";
            label6.Text = "Su = 10 TL";
            label7.Text = "İçecek = 40 TL";
            label8.Text = "Bilet = 100 TL";
            groupBox3.Text = "Hesaplama";
            label9.Text = "Toplam Fiyat:";
            Lbltoplam.Text = "0 TL";
            button1.Text = "Hesapla";
            label11.Text = "Sinema Büfe Satış Paneli";
            label13.Text = "Kasa";
            LblKasa.Text = "0 TL";
        }
        int kasatutar = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int misir, su, içecek, bilet, toplam;
            misir = Convert.ToInt32(TxtMisir.Text);
            su = Convert.ToInt32(TxtSu.Text);
            içecek = Convert.ToInt32(TxtIcecek.Text);
            bilet = Convert.ToInt32(Txtbilet.Text);

            toplam = misir * 70 + su * 10 + içecek * 40 + bilet * 100;
            Lbltoplam.Text = toplam.ToString() + " TL";

            kasatutar = kasatutar + toplam;
            LblKasa.Text = kasatutar.ToString()+ " TL";


        }

    }
}
