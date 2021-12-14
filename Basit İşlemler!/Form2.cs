using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Basit_İşlemler_
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, sonuc;
            a = Convert.ToDouble(textBox1.Text);
            b = Convert.ToDouble(textBox2.Text);

            if (comboBox1.Text=="toplama")
            {
                sonuc = a + b;
                label4.Text = sonuc.ToString();
            }
            if (comboBox1.Text == "çıkarma")
            {
                sonuc = a - b;
                label4.Text = sonuc.ToString();
            }
            if (comboBox1.Text == "carpma")
            {
                sonuc = a * b;
                label4.Text = sonuc.ToString();
            }
            if (comboBox1.Text == "bölmr")
            {
                sonuc = a / b;
                label4.Text = sonuc.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.Show();
        }
    }
}
