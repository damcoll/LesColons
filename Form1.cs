using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LesColons
{
    public partial class Form1 : Form
    {
        game plateau;
        int select;
        public Form1()
        {
            InitializeComponent();
            plateau = new game();
            select = 0;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                if (sender.Equals(tableLayoutPanel1.Controls[i]))
                {
                    if (select == 1)
                    {
                        plateau.tab[i] = 1;
                        tableLayoutPanel1.Controls[i].BackgroundImage = LesColons.Properties.Resources.maison;
                        tableLayoutPanel1.Controls[i].BackgroundImageLayout = ImageLayout.Stretch;
                    }
                }
            }
        }
        class game
        {
            public int[] tab = new int[100];

            public game()
            {

            }
        }
        class coordonee
        {
            public int x;
            public int y;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            select = 1;
        }

        private void pictureBox102_Click(object sender, EventArgs e)
        {
            select = 0;
        }
    }
}
