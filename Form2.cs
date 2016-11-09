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
    public partial class Form2 : Form
    {
        public static int select;
        public Form2(int co)
        {
            select = co;
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            select = 1;
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox102_Click(object sender, EventArgs e)
        {
            select = 0;
        }

        private void pictureBox103_Click(object sender, EventArgs e)
        {
            select = 2;
        }

        private void pictureBox104_Click(object sender, EventArgs e)
        {
            select = 3;
        }

        private void pictureBox105_Click(object sender, EventArgs e)
        {
            select = 4;
        }

        private void pictureBox106_Click(object sender, EventArgs e)
        {
            select = 5;
        }

        private void pictureBox107_Click(object sender, EventArgs e)
        {
            select = 6;
        }

        private void pictureBox108_Click(object sender, EventArgs e)
        {
            select = 7;
        }

        private void pictureBox109_Click(object sender, EventArgs e)
        {
            select = 8;
        }

        private void pictureBox110_Click(object sender, EventArgs e)
        {
            select = 9;
        }
    }
}
