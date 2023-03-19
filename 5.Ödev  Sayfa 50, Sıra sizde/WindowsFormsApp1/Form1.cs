using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sicaklık;
            sicaklık = Convert.ToInt32(textBox1.Text);
            if (sicaklık < 0)
            {
                label1.Text = ("0’dan büyük bir sayıgiriniz");
            }
            else if (sicaklık > 0 && sicaklık <= 10)
            {
                label1.Text = ("Hava soğuk");
            }
            else if (sicaklık > 10 && sicaklık <= 25)
            {
                label1.Text = ("Hava Hafif sıcak");
            }
        
            else if (sicaklık > 25 )
            {
                label1.Text = ("Hava Sıcak");
            }
        }

       
    }
}












