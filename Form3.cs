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
    public partial class Form3 : Form
    {
        public static int select;
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            select = 1;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            select = 2;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            select = 3;
        }


        private void label6_Click(object sender, EventArgs e)
        {
            select = 4;
        }
    }
}
