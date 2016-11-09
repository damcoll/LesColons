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
    public partial class Form4 : Form
    {
        public static int select;
        public Form4()
        {
            select = 0;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            select = 1;
            this.Hide();
        }
    }
}
