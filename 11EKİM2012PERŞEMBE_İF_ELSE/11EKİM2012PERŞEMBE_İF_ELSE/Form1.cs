using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _11EKİM2012PERŞEMBE_İF_ELSE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int makarna = int.Parse(textBox1.Text);
            int adana = int.Parse(textBox1.Text);
            int izgara = int.Parse(textBox1.Text);
            int yaprak = int.Parse(textBox1.Text);
            int zeytin = int.Parse(textBox1.Text);
            int menemen = int.Parse(textBox1.Text);
            int sıfırla = int.Parse(textBox1.Text);
           
            if (makarna == 1)
            { textBox2.Text = "Makarna"; textBox3.Text = "10 Dakika"; }
            else if (adana == 2)
            { textBox2.Text = "Adana"; textBox3.Text = "40 Dakika"; }
            else if (izgara == 3)
            { textBox2.Text = "İzgara"; textBox3.Text = "150 Dakika"; }
            else if (yaprak == 4)
            { textBox2.Text = "Yaprak Sarma"; textBox3.Text = "240 Dakika"; }
            else if (zeytin == 5)
            { textBox2.Text = "Zeytin Yağlı Dolma"; textBox3.Text = "120 Dakika"; }
            else if (menemen == 6)
            { textBox2.Text = "Menemen"; textBox3.Text = "45 Dakika"; }
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sıfırla = int .Parse (textBox1 .Text );
            if (sıfırla < 7)
            { textBox2.Text = " "; textBox3.Text = " "; textBox1.Text = ""; }
        }
    }
}
