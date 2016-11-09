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
    public partial class Form5 : Form
    {
        Form1 global;
        public Form5(Form1 Form1)
        {
            InitializeComponent();
            global = Form1;
            label1.Text = "Bonheur : " +  global.plateau.bonheur;
            label3.Text = "Chomage : " + global.plateau.pop_dispo;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            label1.Text = "Bonheur : " + global.plateau.bonheur;
            label3.Text = "Chomage : " + global.plateau.pop_dispo;
        }
    }
}
