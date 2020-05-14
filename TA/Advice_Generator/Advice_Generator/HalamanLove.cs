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
    public partial class HalamanLove : UserControl
    {
        public HalamanLove()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {



            int hasilpersencinta;
            Random persencinta = new Random();

            hasilpersencinta = persencinta.Next(1, 6);



            
                switch (hasilpersencinta)
                {
                    case 1:
                        MessageBox.Show("A relationship between " + namamu.Text + " and " + crushmu.Text + " chance is very small.\nA successful relationship is possible, \nbut you both have to work on it.");
                        break;
                    case 2:
                        MessageBox.Show("The chance of a relationship working out between " + namamu.Text + " and " + crushmu.Text + " is not very big, \nbut a relationship is very well possible, if the two of you really want it to, \nand are prepared to make some sacrifices for it.");
                        break;
                    case 3:
                        MessageBox.Show("A relationship might work out between " + namamu.Text + " and " + crushmu.Text + ", but the chance is quite small.\nDo not sit back and think that it will all work out fine, because it might not be working out the way you wanted it to.\nSpend as much time with each other as possible.");
                        break;
                    case 4:
                        MessageBox.Show("A relationship between " + namamu.Text + " and " + crushmu.Text + " has a reasonable chance of working out, \nbut on the other hand, it might not. Your relationship may suffer good and bad times.");
                        break;
                    case 5:
                        MessageBox.Show("A relationship between " + namamu.Text + " and " + crushmu.Text + " has a very good chance of being successful, \nbut this doesn't mean that you don't have to work on the relationship. \nRemember that every relationship needs spending time together, talking with each other etc.");
                        break;
                }
            
        }
    }
}
