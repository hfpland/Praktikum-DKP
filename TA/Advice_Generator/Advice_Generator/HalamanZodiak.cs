using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Advice_Generator
{
    public partial class HalamanZodiak : UserControl
    {
        public HalamanZodiak()
        {
            InitializeComponent();
            label2.Text = DateTime.Now.ToString("MMMM");
        }

        public void zodiak01_Click(object sender, EventArgs e)
        {
            string bwtmanggilramalan;
            Zodiak1 n = new Zodiak1();

            bwtmanggilramalan = n.factorial().ToString();
             MessageBox.Show(bwtmanggilramalan);

        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            string bwtmanggilramalan;
            Zodiak2 n = new Zodiak2();

            bwtmanggilramalan = n.factorial().ToString();
            MessageBox.Show(bwtmanggilramalan);
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            string bwtmanggilramalan;
            Zodiak3 n = new Zodiak3();

            bwtmanggilramalan = n.factorial().ToString();
            MessageBox.Show(bwtmanggilramalan);
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            string bwtmanggilramalan;
            Zodiak4 n = new Zodiak4();

            bwtmanggilramalan = n.factorial().ToString();
            MessageBox.Show(bwtmanggilramalan);
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            string bwtmanggilramalan;
            Zodiak5 n = new Zodiak5();

            bwtmanggilramalan = n.factorial().ToString();
            MessageBox.Show(bwtmanggilramalan);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            string bwtmanggilramalan;
            Zodiak6 n = new Zodiak6();

            bwtmanggilramalan = n.factorial().ToString();
            MessageBox.Show(bwtmanggilramalan);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            string bwtmanggilramalan;
            Zodiak7 n = new Zodiak7();

            bwtmanggilramalan = n.factorial().ToString();
            MessageBox.Show(bwtmanggilramalan);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            string bwtmanggilramalan;
            Zodiak8 n = new Zodiak8();

            bwtmanggilramalan = n.factorial().ToString();
            MessageBox.Show(bwtmanggilramalan);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            string bwtmanggilramalan;
            Zodiak9 n = new Zodiak9();

            bwtmanggilramalan = n.factorial().ToString();
            MessageBox.Show(bwtmanggilramalan);
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            string bwtmanggilramalan;
            Zodiak10 n = new Zodiak10();

            bwtmanggilramalan = n.factorial().ToString();
            MessageBox.Show(bwtmanggilramalan);
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            string bwtmanggilramalan;
            Zodiak11 n = new Zodiak11();

            bwtmanggilramalan = n.factorial().ToString();
            MessageBox.Show(bwtmanggilramalan);
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            string bwtmanggilramalan;
            Zodiak12 n = new Zodiak12();

            bwtmanggilramalan = n.factorial().ToString();
            MessageBox.Show(bwtmanggilramalan);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
