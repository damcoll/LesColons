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
            label8.Text = "fer : " + Convert.ToString(plateau.fer);
            label11.Text = "nouriture : " + Convert.ToString(plateau.nour);
            label4.Text = "or : " + Convert.ToString(plateau.or);
            label2.Text = "Population : " + Convert.ToString(plateau.pop);
            label3.Text = "jour : " + Convert.ToString(plateau.date);
            //label12.Text = "+" + Convert.ToString(plateau.prodTotalMine());
            label14.Text = "+" + Convert.ToString(plateau.prodTotalMine());
            label12.Text = "+" + Convert.ToString(plateau.prodTotalFerme() - plateau.pop);
            label17.Text = "prestige : " + Convert.ToString(plateau.prestige);
            label16.Text = "+" + Convert.ToString(plateau.nataliter * plateau.pop);
            label15.Text = "+" + Convert.ToString(plateau.prodTotalScirie());
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
                        plateau.population_max += 3;
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
                    if (select == 3 && plateau.or >= plateau.ferme.or && plateau.bois >= plateau.ferme.bois)
                    {
                        plateau.or -= plateau.ferme.or;
                        plateau.bois -= plateau.ferme.bois;
                        plateau.pop_dispo -= plateau.ferme.pop;
                        plateau.tab[i] = 3;
                        tableLayoutPanel1.Controls[i].BackgroundImage = LesColons.Properties.Resources.ferme;
                        tableLayoutPanel1.Controls[i].BackgroundImageLayout = ImageLayout.Stretch;
                    }
                    if (select == 4 && plateau.or >= plateau.mine.or && plateau.bois >= plateau.mine.bois)
                    {
                        plateau.or -= plateau.mine.or;
                        plateau.bois -= plateau.mine.bois;
                        plateau.pop_dispo -= plateau.mine.pop;
                        plateau.tab[i] = 4;
                        tableLayoutPanel1.Controls[i].BackgroundImage = LesColons.Properties.Resources.mine;
                        tableLayoutPanel1.Controls[i].BackgroundImageLayout = ImageLayout.Stretch;
                    }
                    if (select == 5 && plateau.or >= plateau.scierie.or && plateau.bois >= plateau.scierie.bois)
                    {
                        plateau.or -= plateau.scierie.or;
                        plateau.bois -= plateau.scierie.bois;
                        plateau.pop_dispo -= plateau.scierie.pop;
                        plateau.tab[i] = 5;
                        tableLayoutPanel1.Controls[i].BackgroundImage = LesColons.Properties.Resources.scirie;
                        tableLayoutPanel1.Controls[i].BackgroundImageLayout = ImageLayout.Zoom;
                    }
                    if (select == 6 && plateau.or >= plateau.monu.or && plateau.bois >= plateau.monu.bois && plateau.fer >= plateau.monu.fer)
                    {
                        plateau.or -= plateau.monu.or;
                        plateau.bois -= plateau.monu.bois;
                        plateau.fer -= plateau.monu.fer;
                        plateau.tab[i] = 6;
                        tableLayoutPanel1.Controls[i].BackgroundImage = LesColons.Properties.Resources.monument;
                        tableLayoutPanel1.Controls[i].BackgroundImageLayout = ImageLayout.Zoom;
                    }
                    if (select == 7 && plateau.or >= plateau.ecole.or && plateau.bois >= plateau.ecole.bois && plateau.fer >= plateau.ecole.fer)
                    {
                        plateau.or -= plateau.ecole.or;
                        plateau.technologie += plateau.prod_ecole;
                        plateau.bois -= plateau.ecole.bois;
                        plateau.fer -= plateau.ecole.fer;
                        plateau.tab[i] = 7;
                        tableLayoutPanel1.Controls[i].BackgroundImage = LesColons.Properties.Resources.ecole;
                        tableLayoutPanel1.Controls[i].BackgroundImageLayout = ImageLayout.Zoom;
                    }
                    if (select == 8 && plateau.or >= plateau.entrepos.or && plateau.bois >= plateau.entrepos.bois && plateau.fer >= plateau.entrepos.fer)
                    {
                        plateau.or -= plateau.entrepos.or;
                        plateau.fer_max += plateau.entrepos.stock_fer;
                        plateau.bois_max += plateau.entrepos.stock_bois;
                        plateau.bois -= plateau.entrepos.bois;
                        plateau.fer -= plateau.entrepos.fer;
                        plateau.tab[i] = 8;
                        tableLayoutPanel1.Controls[i].BackgroundImage = LesColons.Properties.Resources.entrepos;
                        tableLayoutPanel1.Controls[i].BackgroundImageLayout = ImageLayout.Zoom;
                    }
                    if (select == 9 && plateau.or >= plateau.gardeManger.or && plateau.bois >= plateau.gardeManger.bois && plateau.fer >= plateau.gardeManger.fer)
                    {
                        plateau.or -= plateau.gardeManger.or;
                        plateau.nour_max += plateau.gardeManger.stock_nour;
                        plateau.bois -= plateau.gardeManger.bois;
                        plateau.fer -= plateau.gardeManger.fer;
                        plateau.tab[i] = 9;
                        tableLayoutPanel1.Controls[i].BackgroundImage = LesColons.Properties.Resources.gardeManger;
                        tableLayoutPanel1.Controls[i].BackgroundImageLayout = ImageLayout.Zoom;
                    }
                }
            }
            label1.Text = "Bois : " + Convert.ToString(plateau.bois);
            label8.Text = "fer : " + Convert.ToString(plateau.fer);
            label11.Text = "nouriture : " + Convert.ToString(plateau.nour);
            label4.Text = "or : " + Convert.ToString(plateau.or);
            label2.Text = "Population : " + Convert.ToString(plateau.pop);
            label3.Text = "jour : " + Convert.ToString(plateau.date);
            //label12.Text = "+" + Convert.ToString(plateau.prodTotalMine());
            label14.Text = "+" + Convert.ToString(plateau.prodTotalMine());
            label12.Text = "+" + Convert.ToString(plateau.prodTotalFerme() - plateau.pop);
            label17.Text = "prestige : " + Convert.ToString(plateau.prestige);
            label16.Text = "+" + Convert.ToString(plateau.nataliter * plateau.pop);
            label15.Text = "+" + Convert.ToString(plateau.prodTotalScirie());
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
            public double prod_ecole;
            public int date;
            public double prestige;
            public double nataliter;
            public double technologie;
            public double bonheur;
            public double population_max;
            public double bois_max;
            public double fer_max;
            public double nour_max;
            public double or_max;

            public gardeManger gardeManger;
            public entrepos entrepos;
            public maison maison;
            public route route;
            public ferme ferme;
            public mine mine;
            public scierie scierie;
            public monument monu;
            public ecole ecole;
            double prod_ferme;
            double prod_mine;
            double prod_scirie;

            public game()
            {
                bois = 100;
                fer = 100;
                nour = 100;
                or = 1000;
                pop = 0;
                pop_dispo = 0;
                prod_ferme = 1.5;
                prod_mine = 0.5;
                prod_scirie = 0.5;
                prod_ecole = 0.5;
                prestige = 0;
                nataliter = 0.005;
                bonheur = 0;
                technologie = 0;
                population_max = 0;
                or_max = 1000;
                fer_max = 100;
                bois_max = 100;
                nour_max = 100;
                maison = new maison(10);
                route = new route(10);
                ferme = new ferme(10, 10, 1);
                mine = new mine(12, 12, 1);
                scierie = new scierie(12, 12, 1);
                monu = new monument(100, 100, 100);
                ecole = new ecole(20, 20, 20);
                entrepos = new entrepos(10, 5, 10);
                gardeManger = new gardeManger(10, 5, 10);
            }
            public double prodTotalFerme()
            {
                int r = 0;
                for (int i = 0; i < 100; i++)
                {
                    if (tab[i] == 3) r++;
                }
                if (pop_dispo < 0)
                {

                    return r * prod_ferme / (pop_dispo * (-2) * prod_ferme);
                }
                return r * prod_ferme;
            }
            public double prodTotalMine()
            {
                int r = 0;
                for (int i = 0; i < 100; i++)
                {
                    if (tab[i] == 4) r++;
                }
                if (pop_dispo < 0)
                {

                    return r * prod_mine / (pop_dispo * (-2) * prod_mine);
                }
                return r * prod_mine;
            }
            public double prodTotalScirie()
            {
                int r = 0;
                for (int i = 0; i < 100; i++)
                {
                    if (tab[i] == 5) r++;
                }
                if (pop_dispo < 0)
                {

                    return r * prod_scirie / (pop_dispo * (-2) * prod_scirie);
                }
                return r * prod_scirie;
            }
            public double prodTotalMonument()
            {
                int r = 0;
                for (int i = 0; i < 100; i++)
                {
                    if (tab[i] == 6) r++;
                }
                return r;
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
        class mine
        {
            public double bois;
            public double or;
            public double pop;
            public mine(double bois_prix, double or_prix, double popo)
            {
                pop = popo;
                bois = bois_prix;
                or = or_prix;
            }
        }
        class scierie
        {
            public double bois;
            public double or;
            public double pop;
            public scierie(double bois_prix, double or_prix, double popo)
            {
                pop = popo;
                bois = bois_prix;
                or = or_prix;
            }
        }
        class monument
        {
            public double bois;
            public double or;
            public double fer;
            public monument(double bois_prix, double or_prix, double fer_prix)
            {
                fer = fer_prix;
                bois = bois_prix;
                or = or_prix;
            }
        }
        class ecole
        {
            public double bois;
            public double or;
            public double fer;
            public ecole(double bois_prix, double or_prix, double fer_prix)
            {
                fer = fer_prix;
                bois = bois_prix;
                or = or_prix;
            }
        }
        class entrepos
        {
            public double bois;
            public double or;
            public double fer;

            public double stock_fer;
            public double stock_bois;
            public entrepos(double bois_prix, double or_prix, double fer_prix)
            {
                fer = fer_prix;
                bois = bois_prix;
                or = or_prix;
                stock_bois = 50;
                stock_fer = 50;
            }
        }
        class gardeManger
        {
            public double bois;
            public double or;
            public double fer;

            public double stock_nour;
            public gardeManger(double bois_prix, double or_prix, double fer_prix)
            {
                fer = fer_prix;
                bois = bois_prix;
                or = or_prix;
                stock_nour = 50;
            }
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
            plateau.date++;
            plateau.prestige += 0.05 * plateau.bonheur + 0.5 * plateau.prodTotalMonument();
            plateau.nour -= plateau.pop;
            plateau.nour += plateau.prodTotalFerme();
            plateau.pop += plateau.pop * plateau.nataliter;
            plateau.pop_dispo += plateau.pop * plateau.nataliter;
            plateau.bonheur += calcul_bonheur(); 
            if (plateau.nour < 0)
            {
                plateau.pop--;
            }
            if (plateau.pop < 0)
            {
                timer1.Stop();
                MessageBox.Show("perdu");
            }
            if (plateau.nour > plateau.nour_max) plateau.nour = plateau.nour_max;
            if (plateau.or > plateau.or_max) plateau.or = plateau.or_max;
            if (plateau.bois > plateau.bois_max) plateau.bois = plateau.bois_max;
            if (plateau.fer > plateau.fer_max) plateau.fer = plateau.fer_max;
            //plateau.or += plateau.prodTotalMine();
            plateau.fer += plateau.prodTotalMine();
            plateau.bois += plateau.prodTotalScirie();
            label1.Text = "Bois : " + Convert.ToString(plateau.bois);
            label8.Text = "fer : " + Convert.ToString(plateau.fer);
            label11.Text = "nouriture : " + Convert.ToString(plateau.nour);
            label4.Text = "or : " + Convert.ToString(plateau.or);
            label2.Text = "Population : " + Convert.ToString(plateau.pop);
            label3.Text = "jour : " + Convert.ToString(plateau.date);
            //label12.Text = "+" + Convert.ToString(plateau.prodTotalMine());
            label14.Text = "+" + Convert.ToString(plateau.prodTotalMine());
            label15.Text = "+" + Convert.ToString(plateau.prodTotalScirie());
            label12.Text = "+" + Convert.ToString(plateau.prodTotalFerme() - plateau.pop);
            label17.Text = "prestige : " + Convert.ToString(plateau.prestige);
            label16.Text = "+" + Convert.ToString(plateau.nataliter * plateau.pop);
        }

        public double calcul_bonheur()
        {
            double indice = 1;

            if (plateau.population_max < plateau.pop) indice -= 1;
            else indice += 1;
            if (plateau.pop_dispo >= plateau.pop * 0.5) indice -= 1;
            else indice += 1;
            return indice * plateau.pop;
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

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) timer1.Enabled = !timer1.Enabled;
        }
    }
}
