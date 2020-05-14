using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Advice_Generator
{
    public partial class HalamanUtama : Form
    {
        public HalamanUtama()
        {
            InitializeComponent();
            halamanHome1.BringToFront();
        }

        private void HalamanUtama_Load(object sender, EventArgs e)
        {

        }

        private void gradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            halamanHome1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            halamanAdvice1.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            halamanNumber1.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            halamanLove1.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            halamanZodiak1.BringToFront();
        }
    }
}
