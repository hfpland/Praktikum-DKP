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
    public partial class HalamanAdvice : UserControl
    {
        public HalamanAdvice()
        {
            InitializeComponent();
        }
        Random saranrndm = new Random();
        public string[] isisaran =
            {
                    "Don't put off until tomorrow what you can enjoy today.",
                    "Do not give up your dream, even if it seems unattainable to you!",
                    "The secret of success is sincerity: if you learn to imitate it, \n nothing will be impossible for you.",
                    "Do not play the lottery, but think how you can make money with your mind.",
                    "Don't do anything important until tomorrow!",
                    "When it seems that the problem can't be solved, try to look at it from the other side, \n do it in a way that no one else has done before.",
                    "When we achieve one goal, we see new ones in front of us.\n So you can turn into a real squirrel in the wheel. Get some rest!",
                    "Quiet! Not all at once!",
                    "If you buy a phone every time, you will definitely not have enough money for an apartment!",
                    "In this world, we are rich not what we receive, but what we give.",
                    "Exercise for at least 15 minutes a day.",
                    "Good manners are the Foundation of everything!",
                    "Drink more fluid, best of ordinary water.",
                    "The Longest Way begins with a small step.",
                    "Do not join the battle, the victory in which does not depend on you.",
                    "When it seems that the problem can't be solved, try to look at it from the other side, \n do it in a way that no one else has done before.",
                    "You will not have a second chance to make the first impression.",
                    "Go to bed without clothes today and tomorrow you will have a wonderful day!",
            };
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int index = saranrndm.Next(isisaran.Length - 1);
            Sarannyadisini.Text = isisaran[index].ToString();
        }

        private void Sarannyadisini_Click(object sender, EventArgs e)
        {

        }
    }
}
