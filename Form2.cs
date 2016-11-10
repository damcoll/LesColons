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
        public Form1 form;
        public Form2(Form1 form1)
        {
            select = 0;
            form = form1;
            InitializeComponent();
            label11.Text = "";
            label12.Text = "";
            label13.Text = "";
            label14.Text ="";

            pictureBox1.BackgroundImage = null;

            label5.Text = null;
            pictureBox103.BackgroundImage = null;
            pictureBox2.BackgroundImage = null;
            label6.Text = null;
            pictureBox104.BackgroundImage = null;
            label7.Text = null;
            pictureBox105.BackgroundImage = null;
            label9.Text = null;
            pictureBox106.BackgroundImage = null;
            label10.Text = null;
            pictureBox107.BackgroundImage = null;
            label18.Text = null;
            pictureBox108.BackgroundImage = null;
            label19.Text = null;
            pictureBox109.BackgroundImage = null;
            label20.Text = null;
            pictureBox110.BackgroundImage = null;
            label15.Text = null;
            label21.Text = null;
            pictureBox3.BackgroundImage = null;
            label1.Text = null;
            pictureBox2.BorderStyle = BorderStyle.None;
            pictureBox103.BorderStyle = BorderStyle.None;
            pictureBox1.BorderStyle = BorderStyle.None;
            pictureBox104.BorderStyle = BorderStyle.None;
            pictureBox105.BorderStyle = BorderStyle.None;
            pictureBox106.BorderStyle = BorderStyle.None;
            pictureBox107.BorderStyle = BorderStyle.None;
            pictureBox108.BorderStyle = BorderStyle.None;
            pictureBox109.BorderStyle = BorderStyle.None;
            pictureBox110.BorderStyle = BorderStyle.None;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Habitation") select = 1;
            if (comboBox1.Text == "Agriculture") select = 2;
            if (comboBox1.Text == "Exploitation") select = 3;
            if (comboBox1.Text == "Sciences") select = 4;
            if (comboBox1.Text == "Stockage") select = 5;
            if (comboBox1.Text == "Comerce" && form.plateau.tech.comerce_bool) select = 6;
            if (comboBox1.Text == "Religion") select = 7;
        }

       

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            if (sender.Equals(pictureBox1) && comboBox1.Text == "Habitation")
            {
                label11.Text = Convert.ToString(form.plateau.bat[0].maison.res.bois) ;
                label12.Text = Convert.ToString(form.plateau.bat[0].maison.res.fer);
                label13.Text = Convert.ToString(form.plateau.bat[0].maison.res.or);
                label14.Text = Convert.ToString(form.plateau.bat[0].maison.res.nouriture);
            }
            if (sender.Equals(pictureBox1) && comboBox1.Text == "Agriculture")
            {
                label11.Text = Convert.ToString(form.plateau.bat[0].ferme.res.bois);
                label12.Text = Convert.ToString(form.plateau.bat[0].ferme.res.fer);
                label13.Text = Convert.ToString(form.plateau.bat[0].ferme.res.or);
                label14.Text = Convert.ToString(form.plateau.bat[0].ferme.res.nouriture);
            }
            if (sender.Equals(pictureBox1) && comboBox1.Text == "Exploitation")
            {
                label11.Text = Convert.ToString(form.plateau.bat[0].scierie.res.bois);
                label12.Text = Convert.ToString(form.plateau.bat[0].scierie.res.fer);
                label13.Text = Convert.ToString(form.plateau.bat[0].scierie.res.or);
                label14.Text = Convert.ToString(form.plateau.bat[0].scierie.res.nouriture);
            }
            if (sender.Equals(pictureBox1) && comboBox1.Text == "Sciences")
            {
                label11.Text = Convert.ToString(form.plateau.bat[0].ecole.res.bois);
                label12.Text = Convert.ToString(form.plateau.bat[0].ecole.res.fer);
                label13.Text = Convert.ToString(form.plateau.bat[0].ecole.res.or);
                label14.Text = Convert.ToString(form.plateau.bat[0].ecole.res.nouriture);
            }
            if (sender.Equals(pictureBox1) && comboBox1.Text == "Stockage")
            {
                label11.Text = Convert.ToString(form.plateau.bat[0].entrepos.res.bois);
                label12.Text = Convert.ToString(form.plateau.bat[0].entrepos.res.fer);
                label13.Text = Convert.ToString(form.plateau.bat[0].entrepos.res.or);
                label14.Text = Convert.ToString(form.plateau.bat[0].entrepos.res.nouriture);
            }
            if (sender.Equals(pictureBox1) && comboBox1.Text == "Comerce" && form.plateau.tech.comerce_bool)
            {
                label11.Text = Convert.ToString(form.plateau.bat[0].mag.res.bois);
                label12.Text = Convert.ToString(form.plateau.bat[0].mag.res.fer);
                label13.Text = Convert.ToString(form.plateau.bat[0].mag.res.or);
                label14.Text = Convert.ToString(form.plateau.bat[0].mag.res.nouriture);
            }
            if (sender.Equals(pictureBox1) && comboBox1.Text == "Religion") 
            {
                label11.Text = Convert.ToString(form.plateau.bat[0].monu.res.bois);
                label12.Text = Convert.ToString(form.plateau.bat[0].monu.res.fer);
                label13.Text = Convert.ToString(form.plateau.bat[0].monu.res.or);
                label14.Text = Convert.ToString(form.plateau.bat[0].monu.res.nouriture);

            }
            if (sender.Equals(pictureBox2) && comboBox1.Text == "Exploitation")
            {
                label11.Text = Convert.ToString(form.plateau.bat[0].mine.res.bois);
                label12.Text = Convert.ToString(form.plateau.bat[0].mine.res.fer);
                label13.Text = Convert.ToString(form.plateau.bat[0].mine.res.or);
                label14.Text = Convert.ToString(form.plateau.bat[0].mine.res.nouriture);
            }
            if (sender.Equals(pictureBox2) && comboBox1.Text == "Stockage")
            {
                label11.Text = Convert.ToString(form.plateau.bat[0].gardeManger.res.bois);
                label12.Text = Convert.ToString(form.plateau.bat[0].gardeManger.res.fer);
                label13.Text = Convert.ToString(form.plateau.bat[0].gardeManger.res.or);
                label14.Text = Convert.ToString(form.plateau.bat[0].gardeManger.res.nouriture);
            }
        }

        private void comboBox1_TextUpdate(object sender, EventArgs e)
        {
            select = 0;
            if (comboBox1.Text == "Habitation")
            {
                pictureBox1.BackgroundImage = LesColons.Properties.Resources.maison;
                label5.Text = "maison";
                pictureBox2.BackgroundImage = null;

                pictureBox103.BackgroundImage = null;
                label6.Text = null;
                pictureBox104.BackgroundImage = null;
                label7.Text = null;
                pictureBox105.BackgroundImage = null;
                label9.Text = null;
                pictureBox106.BackgroundImage = null;
                label10.Text = null;
                pictureBox107.BackgroundImage = null;
                label18.Text = null;
                pictureBox108.BackgroundImage = null;
                label19.Text = null;
                pictureBox109.BackgroundImage = null;
                label20.Text = null;
                pictureBox110.BackgroundImage = null;
                label15.Text = null;

            
                pictureBox3.BackgroundImage = null;
                label1.Text = null;

            }
            if (comboBox1.Text == "Agriculture")
            {
                pictureBox1.BackgroundImage = LesColons.Properties.Resources.ferme;
                label5.Text = "ferme";
                pictureBox2.BackgroundImage = null;

                pictureBox103.BackgroundImage = null;
                label6.Text = null;
                pictureBox104.BackgroundImage = null;
                label7.Text = null;
                pictureBox105.BackgroundImage = null;
                label9.Text = null;
                pictureBox106.BackgroundImage = null;
                label10.Text = null;
                pictureBox107.BackgroundImage = null;
                label18.Text = null;
                pictureBox108.BackgroundImage = null;
                label19.Text = null;
                pictureBox109.BackgroundImage = null;
                label20.Text = null;
                pictureBox110.BackgroundImage = null;
                label15.Text = null;

                pictureBox3.BackgroundImage = null;
                label1.Text = null;
            
            }
            if (comboBox1.Text == "Exploitation")
            {
                pictureBox1.BackgroundImage = LesColons.Properties.Resources.scirie;
                label5.Text = "scirie";
                pictureBox2.BackgroundImage = LesColons.Properties.Resources.mine;
                label6.Text = "mine";
                pictureBox104.BackgroundImage = null;
                label7.Text = null;
                pictureBox105.BackgroundImage = null;
                label9.Text = null;
                pictureBox106.BackgroundImage = null;
                label10.Text = null;
                pictureBox107.BackgroundImage = null;
                label18.Text = null;
                pictureBox108.BackgroundImage = null;
                label19.Text = null;
                pictureBox109.BackgroundImage = null;
                label20.Text = null;
                pictureBox110.BackgroundImage = null;
                label15.Text = null;

                pictureBox3.BackgroundImage = null;
                label1.Text = null;

            }
            if (comboBox1.Text == "Sciences")
            {
                pictureBox1.BackgroundImage = LesColons.Properties.Resources.ecole;
                label5.Text = "ecole";
                pictureBox2.BackgroundImage = null;

                pictureBox103.BackgroundImage = null;
                label6.Text = null;
                pictureBox104.BackgroundImage = null;
                label7.Text = null;
                pictureBox105.BackgroundImage = null;
                label9.Text = null;
                pictureBox106.BackgroundImage = null;
                label10.Text = null;
                pictureBox107.BackgroundImage = null;
                label18.Text = null;
                pictureBox108.BackgroundImage = null;
                label19.Text = null;
                pictureBox109.BackgroundImage = null;
                label20.Text = null;
                pictureBox110.BackgroundImage = null;
                label15.Text = null;

                pictureBox3.BackgroundImage = null;
                label1.Text = null;
            }
            if (comboBox1.Text == "Stockage")
            {
                pictureBox1.BackgroundImage = LesColons.Properties.Resources.entrepos;
                label5.Text = "entrepos";
                pictureBox2.BackgroundImage = LesColons.Properties.Resources.gardeManger;
                label6.Text = "garde Manger";
                pictureBox104.BackgroundImage = null;
                label7.Text = null;
                pictureBox105.BackgroundImage = null;
                label9.Text = null;
                pictureBox106.BackgroundImage = null;
                label10.Text = null;
                pictureBox107.BackgroundImage = null;
                label18.Text = null;
                pictureBox108.BackgroundImage = null;
                label19.Text = null;
                pictureBox109.BackgroundImage = null;
                label20.Text = null;
                pictureBox110.BackgroundImage = null;
                label15.Text = null;

                pictureBox3.BackgroundImage = null;
                label1.Text = null;
            }
            if (comboBox1.Text == "Comerce")
            {
                if (form.plateau.tech.comerce_bool)
                {
                    pictureBox1.BackgroundImage = LesColons.Properties.Resources.magasin;
                    label5.Text = "magasin";
                }
                else
                {
                    pictureBox1.BackgroundImage = null;
                    label5.Text = null;
                }
                pictureBox2.BackgroundImage = null;

                pictureBox103.BackgroundImage = null;
                label6.Text = null;
                pictureBox104.BackgroundImage = null;
                label7.Text = null;
                pictureBox105.BackgroundImage = null;
                label9.Text = null;
                pictureBox106.BackgroundImage = null;
                label10.Text = null;
                pictureBox107.BackgroundImage = null;
                label18.Text = null;
                pictureBox108.BackgroundImage = null;
                label19.Text = null;
                pictureBox109.BackgroundImage = null;
                label20.Text = null;
                pictureBox110.BackgroundImage = null;
                label15.Text = null;

                pictureBox3.BackgroundImage = null;
                label1.Text = null;
            }
            if (comboBox1.Text == "Religion")
            {
                pictureBox1.BackgroundImage = LesColons.Properties.Resources.monument;
                label5.Text = "monument";
                pictureBox2.BackgroundImage = null;
                pictureBox103.BackgroundImage = null;
                label6.Text = null;
                pictureBox104.BackgroundImage = null;
                label7.Text = null;
                pictureBox105.BackgroundImage = null;
                label9.Text = null;
                pictureBox106.BackgroundImage = null;
                label10.Text = null;
                pictureBox107.BackgroundImage = null;
                label18.Text = null;
                pictureBox108.BackgroundImage = null;
                label19.Text = null;
                pictureBox109.BackgroundImage = null;
                label20.Text = null;
                pictureBox110.BackgroundImage = null;
                label15.Text = null;

                pictureBox3.BackgroundImage = null;
                label1.Text = null;
            }
        }

        private void pictureBox102_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Exploitation") select = 8;
            if (comboBox1.Text == "Stockage") select = 9;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            label11.Text = "";
            label12.Text = "";
            label13.Text = "";
            label14.Text = "";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
