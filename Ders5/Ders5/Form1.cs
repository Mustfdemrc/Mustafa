using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Text = "Toplama";
            button2.Text = "Çıkartma";
            button3.Text = "Çarpma";
            button4.Text = "Bölme";
        }

        private void Form1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // MessageBox.Show("Yazı Değiştir.");
            //  MessageBox.Show("Mesajınız", "Başlık");


            /*
                DialogResult result1 = MessageBox.Show("Uygulamayı Kapatmaya Emin misin?",
            "Uygulama Çıkış", MessageBoxButtons.YesNo);
                if (result1 == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {

            }
            */
             


            /*
             
            DialogResult result2 = MessageBox.Show("Uygulamayı Kapatmaya Emin misin?", 
                "Uygulama Çıkış", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (result2 == DialogResult.Yes)
            {

            }
            else if (result2 == DialogResult.No)
            {

            }
            else if (result2 == DialogResult.Cancel)
            {

            }
            
            */

            
             /*
            DialogResult result = MessageBox.Show("Uygulamayı Kapatmaya Emin misin?",
               "Uygulama Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Abort)
            {
                this.Close();
            }
            else if (result == DialogResult.Retry)
            {

            }
            else
            {

            }
            */

           // label1.Text = textBox1.Text;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            string kelime;
            kelime = textBox1.Text;           
            label1.Text =kelime.ToString();
          */
           

            /*
            string ad = textBox1.Text;
            string soyad = textBox2.Text;
            MessageBox.Show("Hoş Geldiniz" + ad + " " + soyad);
            */

           
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            label3.Text = Convert.ToString(a + b);
           
        }
        
        private void label1_Click(object sender, EventArgs e)
        {
        
        }

        private void button2_Click(object sender, EventArgs e)
       
        { 
        
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            label3.Text = Convert.ToString(a - b);
    
        }

        private void button3_Click(object sender, EventArgs e)
        
        {
          
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            label3.Text = Convert.ToString(a * b);
            
        }
        
        
        
        private void button4_Click(object sender, EventArgs e)
        
        {
        
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            label3.Text = Convert.ToString(a / b);
        
        }
        
    }
}
