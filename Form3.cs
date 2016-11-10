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
        public Form1 form1;
        public Form3(Form1 form)
        {
            form1 = form;
            InitializeComponent();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            select = 1;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            select = 2;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            select = 3;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            select = 4;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            select = 5;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            if (form1.plateau.tech.agriculture_bool) select = 6;
        }

        private void label7_Click(object sender, EventArgs e)
        {
            if (form1.plateau.tech.agriculture_bool) select = 7;
        }

        private void label8_Click(object sender, EventArgs e)
        {
            if (form1.plateau.tech.exploitation_bool) select = 8;
        }

        private void label9_Click(object sender, EventArgs e)
        {
            if (form1.plateau.tech.exploitation_bool) select = 9;
        }

        private void label10_Click(object sender, EventArgs e)
        {
            if (form1.plateau.tech.artisan_bool) select = 10;
        }

        private void label11_Click(object sender, EventArgs e)
        {
            if (form1.plateau.tech.artisan_bool) select = 11;
        }

        private void label12_Click(object sender, EventArgs e)
        {
            if (form1.plateau.tech.culte_bool) select = 12;
        }

        private void label13_Click(object sender, EventArgs e)
        {
            if (form1.plateau.tech.education_bool) select = 13;
        }
    }
}
