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
    public partial class HalamanNumber : UserControl
    {
        public HalamanNumber()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Random rndmnmbrgnrtr = new Random();
            textboxanswer.Text = rndmnmbrgnrtr.Next(Convert.ToInt32(textboxfrom.Text), Convert.ToInt32(textboxto.Text)).ToString();
        }

        private void textboxfrom_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textboxto_TextChanged(object sender, EventArgs e)
        {

        }

        private void textboxfrom_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
    }
}
