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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text == "123")
            {
                MessageBox.Show("Hoşgeldin");
                Form2 frm = new Form2();
                frm.Show();
            }
            else  
            {
                MessageBox.Show("Hatalıı Giriş-Tekrar Deneme!");
            }
        }
    }
}
