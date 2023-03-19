using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2.Ödev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            double turkceDogru, matDogru;
            double turkceYanlis, matYanlis;
            double turkceNet, matNet;
            turkceDogru = Convert.ToDouble(textBox1.Text);
            turkceYanlis = Convert.ToDouble(textBox2.Text);
            turkceNet = (turkceDogru - (turkceYanlis / 4));
            textBox3.Text = turkceNet.ToString();
            matDogru = Convert.ToDouble(textBox4.Text);
            matYanlis = Convert.ToDouble(textBox5.Text);
            matNet = (matDogru - (matYanlis / 4));
            textBox6.Text = matNet.ToString();
        }
    }
}
