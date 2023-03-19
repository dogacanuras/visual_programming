using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1.ödev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int etiketFiyati;
            double indirimliFiyat;
            etiketFiyati = Convert.ToInt32(textBox1.Text);
            indirimliFiyat = etiketFiyati - etiketFiyati * 0.10; 
            label3.Text = indirimliFiyat.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int etiketFiyati;
            double indirimliFiyat;
            etiketFiyati = Convert.ToInt32(textBox1.Text);
            indirimliFiyat = etiketFiyati - etiketFiyati * 0.25; 
            label3.Text = indirimliFiyat.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int etiketFiyati;
            double indirimliFiyat;
            etiketFiyati = Convert.ToInt32(textBox1.Text);
            indirimliFiyat = etiketFiyati - etiketFiyati * 0.50; 
            label3.Text = indirimliFiyat.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int etiketFiyati;
            double indirimliFiyat;
            etiketFiyati = Convert.ToInt32(textBox1.Text);
            indirimliFiyat = etiketFiyati - etiketFiyati * 0.75; 
            label3.Text = indirimliFiyat.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
