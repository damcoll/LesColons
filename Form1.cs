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
        public game plateau;
        Form3 Form3;
        Form2 Form2;
        Form5 Form5;
        int cas_modifier;
        public Form1(int co = 0)
        {
            InitializeComponent();

            Form2 = new Form2(0);
            Form2.Show();
            Form2.select = 0;
            plateau = new game();
            for (int i = 0; i < 100; i++)
            {
                tableLayoutPanel1.Controls[i].BackgroundImage = LesColons.Properties.Resources.herbe;
                tableLayoutPanel1.Controls[i].BackgroundImageLayout = ImageLayout.Stretch;
            }
            aff_res();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                if (sender.Equals(tableLayoutPanel1.Controls[i]))
                {
                    if (plateau.tab[i] == 0)
                    {
                        if (Form2.select == 1) creeMaison(i);

                        if (Form2.select == 2) creeRoute(i);
                        if (Form2.select == 3) creeFerme(i);
                        if (Form2.select == 4) creeMine(i);
                        if (Form2.select == 5) creeScirie(i);
                        if (Form2.select == 6) creeMonument(i);
                        if (Form2.select == 7) creeEcole(i);
                        if (Form2.select == 8) creeEntrepos(i);
                        if (Form2.select == 9) creeGardeManger(i);
                        if (Form2.select == 11) creeMagasin(i);
                        // if ()
                    }
                    else
                    {
                        if (plateau.tab[i] == 1 && plateau.tech.habitationI >= 10)
                        {
                            Form4 form4 = new Form4();
                            form4.Show();
                            cas_modifier = i;
                        }
                        else cas_modifier = 0;
                    }
                }
            }
            aff_res();
        }

        private void creeGardeManger(int i)
        {
            if (plateau.tab[i] == 0 && compRes(plateau.res_base, plateau.gardeManger.res))
            {
                sousRes(plateau.res_base, plateau.gardeManger.res);
                plateau.res_max.nouriture += plateau.gardeManger.res_max.nouriture;
                plateau.tab[i] = 9;
                tableLayoutPanel1.Controls[i].BackgroundImage = LesColons.Properties.Resources.gardeManger;
                tableLayoutPanel1.Controls[i].BackgroundImageLayout = ImageLayout.Zoom;
            }
        }

        private void creeEntrepos(int i)
        {
            if (plateau.tab[i] == 0 && compRes(plateau.res_base, plateau.entrepos.res))
            {
                sousRes(plateau.res_base, plateau.entrepos.res);
                plateau.tab[i] = 8;
                plateau.res_max.fer += plateau.gardeManger.res_max.fer;
                plateau.res_max.bois += plateau.gardeManger.res_max.bois;
                tableLayoutPanel1.Controls[i].BackgroundImage = LesColons.Properties.Resources.entrepos;
                tableLayoutPanel1.Controls[i].BackgroundImageLayout = ImageLayout.Zoom;
            }
        }

        private void creeEcole(int i)
        {
            if (plateau.tab[i] == 0 && compRes(plateau.res_base, plateau.ecole.res))
            {
                sousRes(plateau.res_base, plateau.ecole.res);
                plateau.tab[i] = 7;
                plateau.technologie += plateau.ecole.prod_ecole;
                tableLayoutPanel1.Controls[i].BackgroundImage = LesColons.Properties.Resources.ecole;
                tableLayoutPanel1.Controls[i].BackgroundImageLayout = ImageLayout.Zoom;
            }
        }

        private void creeMonument(int i)
        {
            if (plateau.tab[i] == 0 && compRes(plateau.res_base, plateau.monu.res))
            {
                sousRes(plateau.res_base, plateau.monu.res);
                plateau.tab[i] = 6;
                tableLayoutPanel1.Controls[i].BackgroundImage = LesColons.Properties.Resources.monument;
                tableLayoutPanel1.Controls[i].BackgroundImageLayout = ImageLayout.Zoom;
            }
        }

        private void creeScirie(int i)
        {
            if (plateau.tab[i] == 0 && compRes(plateau.res_base, plateau.scierie.res))
            {
                sousRes(plateau.res_base, plateau.scierie.res);
                plateau.pop_dispo -= 1;
                plateau.tab[i] = 5;
                tableLayoutPanel1.Controls[i].BackgroundImage = LesColons.Properties.Resources.scirie;
                tableLayoutPanel1.Controls[i].BackgroundImageLayout = ImageLayout.Zoom;
            }
        }

        private void creeMine(int i)
        {
            if (plateau.tab[i] == 0 && compRes(plateau.res_base, plateau.mine.res))
            {
                sousRes(plateau.res_base, plateau.mine.res);
                plateau.tab[i] = 4;
                plateau.pop_dispo -= 1;
                tableLayoutPanel1.Controls[i].BackgroundImage = LesColons.Properties.Resources.mine;
                tableLayoutPanel1.Controls[i].BackgroundImageLayout = ImageLayout.Zoom;
            }
        }

        private void creeFerme(int i)
        {
            if (plateau.tab[i] == 0 && compRes(plateau.res_base, plateau.ferme.res))
            {
                sousRes(plateau.res_base, plateau.ferme.res);
                plateau.tab[i] = 3;
                plateau.pop_dispo -= 1;
                tableLayoutPanel1.Controls[i].BackgroundImage = LesColons.Properties.Resources.ferme;
                tableLayoutPanel1.Controls[i].BackgroundImageLayout = ImageLayout.Zoom;
            }
        }

        private void creeRoute(int i)
        {
            if (plateau.tab[i] == 0 && compRes(plateau.res_base, plateau.route.res))
            {
                sousRes(plateau.res_base, plateau.route.res);
                plateau.tab[i] = 2;
                tableLayoutPanel1.Controls[i].BackgroundImage = LesColons.Properties.Resources.route;
                tableLayoutPanel1.Controls[i].BackgroundImageLayout = ImageLayout.Zoom;
            }
        }

        private void creeMaison(int i)
        {
            if (plateau.tab[i] == 0 && compRes(plateau.res_base, plateau.maison.res))
            {
                sousRes(plateau.res_base, plateau.maison.res);
                plateau.pop += 1;
                plateau.population_max += 2;
                plateau.pop_dispo += 1;
                plateau.tab[i] = 1;
                tableLayoutPanel1.Controls[i].BackgroundImage = LesColons.Properties.Resources.maison;
                tableLayoutPanel1.Controls[i].BackgroundImageLayout = ImageLayout.Zoom;
            }
        }

        private void creeMagasin(int i)
        {
            if (plateau.tab[i] == 0 && compRes(plateau.res_base, plateau.mag.res))
            {
                sousRes(plateau.res_base, plateau.mag.res);

                plateau.tab[i] = 11;
                tableLayoutPanel1.Controls[i].BackgroundImage = LesColons.Properties.Resources.magasin;
                tableLayoutPanel1.Controls[i].BackgroundImageLayout = ImageLayout.Zoom;
            }
        }

        private void sousRes(ressource r1, ressource r2)
        {
            r1.bois -= r2.bois;
            r1.fer -= r2.fer;
            r1.or -= r2.or;
            r1.nouriture -= r2.nouriture;
        }

        private bool compRes(ressource r1, ressource r2)
        {
            if (r1.bois >= r2.bois && r1.fer >= r2.fer && r1.or >= r2.or && r1.nouriture >= r2.nouriture) return true;
            return false;
        }

        public class game
        {
            public int[] tab = new int[100];
            public double pop;
            public double pop_dispo;

            public int date;
            public double prestige;
            public double nataliter;
            public double technologie;
            public double bonheur;
            public double population_max;

            public gardeManger gardeManger;
            public entrepos entrepos;
            public maison maison;
            public route route;
            public ferme ferme;
            public mine mine;
            public scierie scierie;
            public monument monu;
            public ecole ecole;
            public technologie tech;
            public maison2 maison2;
            public magasin mag;


            public ressource res_base;
            public ressource res_max;

            public game()
            {

                pop = 0;
                pop_dispo = 0;




                prestige = 0;
                nataliter = 0.005;
                bonheur = 0;
                technologie = 0;
                population_max = 0;
                mag = new magasin(10, 5, 1);
                res_base = new ressource(100, 100, 1000, 100);
                res_max = new ressource(100, 100, 1000, 100);
                maison = new maison(10);
                route = new route(10);
                ferme = new ferme(10, 10, 1);
                mine = new mine(12, 12, 1);
                scierie = new scierie(12, 12, 1);
                monu = new monument(100, 100, 100);
                ecole = new ecole(20, 20, 20);
                entrepos = new entrepos(10, 5, 10);
                gardeManger = new gardeManger(10, 5, 10);
                tech = new technologie();
                maison2 = new maison2(10);
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
                    if ((r * ferme.prod_ferme / (pop_dispo * -2 * ferme.prod_ferme) < 0)) return 0;
                    return r * ferme.prod_ferme / (pop_dispo * -2 * ferme.prod_ferme);
                }
                return r * ferme.prod_ferme;
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
                    if (r * mine.prod_mine / (pop_dispo * -2 * mine.prod_mine) < 0) return 0;
                    return r * mine.prod_mine / (pop_dispo * -2 * mine.prod_mine);
                }
                return r * mine.prod_mine;
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
                    if (r * scierie.prod_scirie / (pop_dispo * -2 * scierie.prod_scirie) < 0) return 0;
                    return r * scierie.prod_scirie / (pop_dispo * -2 * scierie.prod_scirie);
                }
                return r * scierie.prod_scirie;
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
            public double prodMagasin()
            {
                int r = 0;
                for (int i = 0; i < 100; i++)
                {
                    if (tab[i] == 11) r++;
                }
                return r * mag.prod_mag;
            }
        }
        public class maison
        {
            public ressource res;

            public maison(double prix_bois)
            {
                res = new ressource(prix_bois, 0, 0, 0);
            }
        }
        public class maison2
        {
            public ressource res;

            public maison2(double prix_bois)
            {
                res = new ressource(prix_bois, 0, 0, 0);
            }
        }
        public class ferme
        {
            public double prod_ferme;
            public ressource res;
            double pop;
            public ferme(double bois_prix, double or_prix, double popo)
            {
                res = new ressource(bois_prix, 0, or_prix, 0);
                pop = popo;
                prod_ferme = 1.5;
            }
        }
        public class route
        {
            public ressource res;
            public route(double prix_or)
            {
                res = new ressource(0, 0, prix_or, 0);
            }
        }
        public class mine
        {
            public double prod_mine;
            public ressource res;
            public double pop;
            public mine(double bois_prix, double or_prix, double popo)
            {
                res = new ressource(bois_prix, 0, or_prix, 0);
                prod_mine = 0.5;
                pop = popo;
            }
        }
        public class scierie
        {
            public double prod_scirie;
            public ressource res;
            public double pop;
            public scierie(double bois_prix, double or_prix, double popo)
            {
                pop = popo;
                res = new ressource(bois_prix, 0, or_prix, 0);
                prod_scirie = 0.5;
            }
        }
        public class monument
        {
            public ressource res;
            public monument(double bois_prix, double or_prix, double fer_prix)
            {
                res = new ressource(bois_prix, fer_prix, or_prix, 0);
            }
        }
        public class ecole
        {
            public double prod_ecole;
            public ressource res;
            public ecole(double bois_prix, double or_prix, double fer_prix)
            {
                res = new ressource(bois_prix, fer_prix, or_prix, 0);
                prod_ecole = 0.5;
            }
        }
        public class entrepos
        {
            public ressource res;

            public ressource res_max;
            public entrepos(double bois_prix, double or_prix, double fer_prix)
            {
                res = new ressource(bois_prix, fer_prix, or_prix, 0);
                res_max = new ressource(50, 50, 0, 0);
            }
        }
        public class gardeManger
        {
            public ressource res;

            public ressource res_max;
            public gardeManger(double bois_prix, double or_prix, double fer_prix)
            {
                res = new ressource(bois_prix, fer_prix, or_prix, 0);
                res_max = new ressource(0, 0, 0, 50);
            }
        }
        public class technologie
        {
            public double educationI;
            public bool educationI_bool;
            public double comerceI;
            public bool comerceI_bool;
            public double agricultureI;
            public bool agricultureI_bool;
            public double habitationI;
            public bool habitationI_bool;

            public technologie()
            {
                educationI = 0;
                comerceI = 0;
                agricultureI = 0;
                habitationI = 0;
                educationI_bool = false;
                comerceI_bool = false;
                agricultureI_bool = false;
                habitationI_bool = false;
            }
        }
        public class ressource
        {
            public double bois;
            public double fer;
            public double or;
            public double nouriture;
            public ressource(double b, double f, double o, double n)
            {
                bois = b;
                fer = f;
                or = o;
                nouriture = n;
            }
        }
        public class magasin
        {
            public double prod_mag;
            public ressource res;
            public double pop;
            public magasin(double bois_prix, double or_prix, double popo)
            {
                res = new ressource(bois_prix, 0, or_prix, 0);
                prod_mag = 0.5;
                pop = popo;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {

            if (plateau.res_base.nouriture < 0)
            {
                plateau.pop--;
            }
            if (plateau.pop < 0)
            {
                timer1.Stop();
                MessageBox.Show("perdu");
            }
            evolution_tech();
            evolution_resource();
            aff_res();
        }

        public void evolution_tech()
        {
            if (plateau.tech.educationI >= 10 && !plateau.tech.habitationI_bool)
            {
                Form3.label1.BackColor = Color.Blue;
                MessageBox.Show("technologie terminer");
                Form3.select = 2;
                plateau.tech.habitationI_bool = true;
            }
            if (plateau.tech.comerceI >= 10 && !plateau.tech.comerceI_bool)
            {
                Form2.pictureBox3.Visible = true;
                Form2.label1.Visible = true;
                Form3.label3.BackColor = Color.Blue;
                MessageBox.Show("technologie terminer");
                Form3.select = 3;
                plateau.tech.comerceI_bool = true;
            }
            if (plateau.tech.agricultureI >= 10 && !plateau.tech.agricultureI_bool)
            {
                Form3.label5.BackColor = Color.Blue;
                MessageBox.Show("technologie terminer");
                Form3.select = 4;
                plateau.tech.agricultureI_bool = true;
            }
            if (plateau.tech.habitationI >= 10 && !plateau.tech.habitationI_bool)
            {
                Form3.label6.BackColor = Color.Blue;
                MessageBox.Show("technologie terminer");
                Form3.select = 5;
                plateau.tech.habitationI_bool = true;
            }
            if (Form3.select == 1) plateau.tech.educationI += plateau.technologie;
            else if (Form3.select == 2) plateau.tech.comerceI += plateau.technologie;
            else if (Form3.select == 3) plateau.tech.agricultureI += plateau.technologie;
            else if (Form3.select == 4) plateau.tech.habitationI += plateau.technologie;
        }
        public void evolution_resource()
        {
            plateau.date++;
            plateau.prestige += 0.05 * plateau.bonheur + 0.5 * plateau.prodTotalMonument();
            plateau.res_base.nouriture -= plateau.pop;
            plateau.res_base.nouriture += plateau.prodTotalFerme();
            plateau.pop += plateau.pop * plateau.nataliter;
            plateau.pop_dispo += plateau.pop * plateau.nataliter;
            plateau.bonheur += calcul_bonheur();
            plateau.res_base.fer += plateau.prodTotalMine();
            plateau.res_base.bois += plateau.prodTotalScirie();
            plateau.res_base.or += plateau.prodMagasin();
            if (plateau.res_base.nouriture > plateau.res_max.nouriture) plateau.res_base.nouriture = plateau.res_max.nouriture;
            if (plateau.res_base.or > plateau.res_max.or) plateau.res_base.or = plateau.res_max.or;
            if (plateau.res_base.bois > plateau.res_max.bois) plateau.res_base.bois = plateau.res_max.bois;
            if (plateau.res_base.fer > plateau.res_max.fer) plateau.res_base.fer = plateau.res_max.fer;


        }

        public double calcul_bonheur()
        {
            double indice = 0;

            if (plateau.population_max < plateau.pop) indice -= 1;
            else indice += 1;
            if (plateau.pop_dispo >= plateau.pop * 0.5) indice -= 1;
            else indice += 1;
            return indice * plateau.pop;
        }

        public void aff_res()
        {
            label1.Text = "Bois : " + Convert.ToString(plateau.res_base.bois);
            label8.Text = "fer : " + Convert.ToString(plateau.res_base.fer);
            label11.Text = "nouriture : " + Convert.ToString(plateau.res_base.nouriture);
            label4.Text = "or : " + Convert.ToString(plateau.res_base.or);
            label2.Text = "Population : " + Convert.ToString(plateau.pop);
            label3.Text = "jour : " + Convert.ToString(plateau.date);
            label13.Text = "+" + Convert.ToString(plateau.prodMagasin());
            label14.Text = "+" + Convert.ToString(plateau.prodTotalMine());
            label12.Text = "+" + Convert.ToString(plateau.prodTotalFerme() - plateau.pop);
            label17.Text = "prestige : " + Convert.ToString(plateau.prestige);
            label16.Text = "+" + Convert.ToString(plateau.nataliter * plateau.pop);
            label15.Text = "+" + Convert.ToString(plateau.prodTotalScirie());
            label16.Text = "+" + Convert.ToString(plateau.nataliter * plateau.pop);
        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) timer1.Enabled = !timer1.Enabled;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (plateau.tab[cas_modifier] == 1)
            {
                if (Form4.select == 1)
                {
                    plateau.tab[cas_modifier] = 10;
                    plateau.population_max += 5;
                    tableLayoutPanel1.Controls[cas_modifier].BackgroundImage = LesColons.Properties.Resources.maison2;
                    tableLayoutPanel1.Controls[cas_modifier].BackgroundImageLayout = ImageLayout.Stretch;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 = new Form2(0);
            Form2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 = new Form3();
            Form3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 = new Form5(this);
            Form5.Show();
        }
    }
}
