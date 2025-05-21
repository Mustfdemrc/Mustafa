using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vize01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            DialogResult result = MessageBox.Show("Uygulamayı Kapatmaya Emin misin?",
               "Uygulama Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
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

            label1.BackColor = Color.Blue;


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.BackColor= Color.Green;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Font = new Font("Time New Roman", 18);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ColorDialog Renk = new ColorDialog();
            Renk.ShowDialog();
            label1.BackColor = Renk.Color;
        }
    }
}
