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
            for (int i = 0; i < 100; i++)
            {
                tableLayoutPanel1.Controls[i].BackgroundImage = LesColons.Properties.Resources.herbe;
                tableLayoutPanel1.Controls[i].BackgroundImageLayout = ImageLayout.Stretch;
            }

                label1.Text = "Bois : " + Convert.ToString(plateau.bois);
            label2.Text = "fer : " + Convert.ToString(plateau.fer);
            label3.Text = "nouriture : " + Convert.ToString(plateau.nour);
            label4.Text = "or : " + Convert.ToString(plateau.or);
            label8.Text = "Population : " + Convert.ToString(plateau.pop);
            select = 0;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                if (sender.Equals(tableLayoutPanel1.Controls[i]))
                {
                    if (select == 1 && plateau.bois >= plateau.maison.bois)
                    {
                        plateau.bois -= plateau.maison.bois;
                        plateau.pop += 1;
                        plateau.pop_dispo += 1;
                        plateau.tab[i] = 1;
                        tableLayoutPanel1.Controls[i].BackgroundImage = LesColons.Properties.Resources.maison;
                        tableLayoutPanel1.Controls[i].BackgroundImageLayout = ImageLayout.Stretch;
                    }
                    if (select == 2 && plateau.or >= plateau.route.or)
                    {
                        plateau.or -= plateau.route.or;
                        plateau.tab[i] = 2;
                        tableLayoutPanel1.Controls[i].BackgroundImage = LesColons.Properties.Resources.route;
                        tableLayoutPanel1.Controls[i].BackgroundImageLayout = ImageLayout.Stretch;
                    }
                    if (select == 3 && plateau.or >= plateau.ferme.or && plateau.bois >= plateau.ferme.bois && plateau.pop_dispo >= plateau.ferme.pop)
                    {
                        plateau.or -= plateau.ferme.or;
                        plateau.bois -= plateau.ferme.bois;
                        plateau.pop_dispo -= plateau.ferme.pop;
                        plateau.tab[i] = 3;
                        tableLayoutPanel1.Controls[i].BackgroundImage = LesColons.Properties.Resources.ferme;
                        tableLayoutPanel1.Controls[i].BackgroundImageLayout = ImageLayout.Stretch;
                    }
                }
            }
            label1.Text = "Bois : " + Convert.ToString(plateau.bois);
            label2.Text = "fer : " + Convert.ToString(plateau.fer);
            label3.Text = "nouriture : " + Convert.ToString(plateau.nour);
            label4.Text = "or : " + Convert.ToString(plateau.or);
            label8.Text = "Population : " + Convert.ToString(plateau.pop);
        }
        class game
        {
            public int[] tab = new int[100];
            public double bois;
            public double fer;
            public double nour;
            public double or;
            public double pop;
            public double pop_dispo;

            public maison maison;
            public route route;
            public ferme ferme;
            double prod_ferme;

            public game()
            {
                bois = 1000;
                fer = 1000;
                nour = 1000;
                or = 1000;
                pop = 0;
                pop_dispo = 0;
                prod_ferme = 1.5;
                maison = new maison(10);
                route = new route(10);
                ferme = new ferme(10, 10,1);
            }
            public double prodTotalFerme()
            {
                int r = 0;
                for (int i= 0; i < 100;i++)
                {
                    if (tab[i] == 3) r++;
                }
                return r * prod_ferme; ;
            }
        }
        class maison
        {
            public double bois;

            public maison(double prix_bois)
            {
                bois = prix_bois;
            }
        }
        class ferme
        {
            public double bois;
            public double or;
            public double pop;
            public ferme(double bois_prix, double or_prix, double popo)
            {
                pop = popo;
                bois = bois_prix;
                or = or_prix;
            }
        }
        class route
        {
            public double or;

            public route(double prix_or)
            {
                or = prix_or;
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

        private void pictureBox103_Click(object sender, EventArgs e)
        {
            select = 2;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            plateau.nour -= plateau.pop;
            plateau.nour += plateau.prodTotalFerme();
            label1.Text = "Bois : " + Convert.ToString(plateau.bois);
            label2.Text = "fer : " + Convert.ToString(plateau.fer);
            label3.Text = "nouriture : " + Convert.ToString(plateau.nour);
            label4.Text = "or : " + Convert.ToString(plateau.or);
            label8.Text = "Population : " + Convert.ToString(plateau.pop);
        }

        private void pictureBox104_Click(object sender, EventArgs e)
        {
            select = 3;
        }
    }
}
