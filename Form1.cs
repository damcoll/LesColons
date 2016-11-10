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

            Form2 = new Form2(this);
            Form2.Show();
            Form2.select = 0;
            plateau = new game();
            for (int i = 0; i < 100; i++)
            {
                tableLayoutPanel1.Controls[i].BackgroundImage = LesColons.Properties.Resources.herbe;
                tableLayoutPanel1.Controls[i].BackgroundImageLayout = ImageLayout.Stretch;
            }
            creeRoute(50);
            plateau.bat[50].reseau = 1;
            aff_res();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                if (sender.Equals(tableLayoutPanel1.Controls[i]))
                {
                    if (plateau.bat[i].type == 0)
                    {
                        if (Form2.select == 1) creeMaison(i);

                        if (Form2.select == 56) creeRoute(i);
                        if (Form2.select == 2) creeFerme(i);
                        if (Form2.select == 8) creeMine(i);
                        if (Form2.select == 3) creeScirie(i);
                        if (Form2.select == 7) creeMonument(i);
                        if (Form2.select == 4) creeEcole(i);
                        if (Form2.select == 5) creeEntrepos(i);
                        if (Form2.select == 9) creeGardeManger(i);
                        if (Form2.select == 6) creeMagasin(i);
                        // if ()
                    }
                    else
                    {
                        if (plateau.bat[i].type == 1 && plateau.tech.maçonnerie_bool)
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
            if (plateau.bat[i].type == 0 && compRes(plateau.res_base, plateau.bat[i].gardeManger.res))
            {
                sousRes(plateau.res_base, plateau.bat[i].gardeManger.res);
                plateau.res_max.nouriture += plateau.bat[i].gardeManger.res_max.nouriture;
                plateau.bat[i].type = 9;
                tableLayoutPanel1.Controls[i].BackgroundImage = LesColons.Properties.Resources.gardeManger;
                tableLayoutPanel1.Controls[i].BackgroundImageLayout = ImageLayout.Zoom;
            }
        }

        private void creeEntrepos(int i)
        {
            if (plateau.bat[i].type == 0 && compRes(plateau.res_base, plateau.bat[i].entrepos.res))
            {
                sousRes(plateau.res_base, plateau.bat[i].entrepos.res);
                plateau.bat[i].type = 8;
                plateau.res_max.fer += plateau.bat[i].gardeManger.res_max.fer;
                plateau.res_max.bois += plateau.bat[i].gardeManger.res_max.bois;
                tableLayoutPanel1.Controls[i].BackgroundImage = LesColons.Properties.Resources.entrepos;
                tableLayoutPanel1.Controls[i].BackgroundImageLayout = ImageLayout.Zoom;
            }
        }

        private void creeEcole(int i)
        {
            if (plateau.bat[i].type == 0 && compRes(plateau.res_base, plateau.bat[i].ecole.res))
            {
                sousRes(plateau.res_base, plateau.bat[i].ecole.res);
                plateau.bat[i].type = 7;
                plateau.technologie += plateau.bat[i].ecole.prod_ecole;
                tableLayoutPanel1.Controls[i].BackgroundImage = LesColons.Properties.Resources.ecole;
                tableLayoutPanel1.Controls[i].BackgroundImageLayout = ImageLayout.Zoom;
            }
        }

        private void creeMonument(int i)
        {
            if (plateau.bat[i].type == 0 && compRes(plateau.res_base, plateau.bat[i].monu.res))
            {
                sousRes(plateau.res_base, plateau.bat[i].monu.res);
                plateau.bat[i].type = 6;
                tableLayoutPanel1.Controls[i].BackgroundImage = LesColons.Properties.Resources.monument;
                tableLayoutPanel1.Controls[i].BackgroundImageLayout = ImageLayout.Zoom;
            }
        }

        private void creeScirie(int i)
        {
            if (plateau.bat[i].type == 0 && compRes(plateau.res_base, plateau.bat[i].scierie.res))
            {
                sousRes(plateau.res_base, plateau.bat[i].scierie.res);
                plateau.pop_dispo -= 1;
                plateau.bat[i].type = 5;
                tableLayoutPanel1.Controls[i].BackgroundImage = LesColons.Properties.Resources.scirie;
                tableLayoutPanel1.Controls[i].BackgroundImageLayout = ImageLayout.Zoom;
            }
        }

        private void creeMine(int i)
        {
            if (plateau.bat[i].type == 0 && compRes(plateau.res_base, plateau.bat[i].mine.res))
            {
                sousRes(plateau.res_base, plateau.bat[i].mine.res);
                plateau.bat[i].type = 4;
                plateau.pop_dispo -= 1;
                tableLayoutPanel1.Controls[i].BackgroundImage = LesColons.Properties.Resources.mine;
                tableLayoutPanel1.Controls[i].BackgroundImageLayout = ImageLayout.Zoom;
            }
        }

        private void creeFerme(int i)
        {
            if (plateau.bat[i].type == 0 && compRes(plateau.res_base, plateau.bat[i].ferme.res))
            {
                sousRes(plateau.res_base, plateau.bat[i].ferme.res);
                plateau.bat[i].type = 3;
                plateau.pop_dispo -= 1;
                tableLayoutPanel1.Controls[i].BackgroundImage = LesColons.Properties.Resources.ferme;
                tableLayoutPanel1.Controls[i].BackgroundImageLayout = ImageLayout.Zoom;
            }
        }

        private void creeRoute(int i)
        {
            if (plateau.bat[i].type == 0 && compRes(plateau.res_base, plateau.bat[i].route.res))
            {
                sousRes(plateau.res_base, plateau.bat[i].route.res);
                plateau.bat[i].type = 2;
                tableLayoutPanel1.Controls[i].BackgroundImage = LesColons.Properties.Resources.route;
                tableLayoutPanel1.Controls[i].BackgroundImageLayout = ImageLayout.Zoom;
            }
        }

        private void creeMaison(int i)
        {
            if (plateau.bat[i].type == 0 && compRes(plateau.res_base, plateau.bat[i].maison.res))
            {
                sousRes(plateau.res_base, plateau.bat[i].maison.res);
                plateau.pop += 1;
                plateau.population_max += 2;
                plateau.pop_dispo += 1;
                plateau.bat[i].type = 1;
                tableLayoutPanel1.Controls[i].BackgroundImage = LesColons.Properties.Resources.maison;
                tableLayoutPanel1.Controls[i].BackgroundImageLayout = ImageLayout.Zoom;
            }
        }

        private void creeMagasin(int i)
        {
            if (plateau.bat[i].type == 0 && compRes(plateau.res_base, plateau.bat[i].mag.res))
            {
                sousRes(plateau.res_base, plateau.bat[i].mag.res);

                plateau.bat[i].type = 11;
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
            public List<batiment> bat = new List<batiment>();
            public double pop;
            public double pop_dispo;

            public int date;
            public double prestige;
            public double nataliter;
            public double technologie;
            public double bonheur;
            public double population_max;
            public technologie tech;



            public ressource res_base;
            public ressource res_max;

            public game()
            {

                pop = 0;
                pop_dispo = 0;
                for (int i = 0; i < 100; i++) bat.Add(new batiment(0));
                prestige = 0;
                nataliter = 0.005;
                bonheur = 0;
                technologie = 0;
                population_max = 0;
                res_base = new ressource(100, 100, 1000, 100);
                res_max = new ressource(100, 100, 1000, 100);

                tech = new technologie();

            }
            public double prodTotalFerme()
            {
                double r = 0;
                for (int i = 0; i < 100; i++)
                {
                    if (bat[i].type == 3 && bat[i].reseau == 1) r += bat[i].ferme.prod_ferme;
                }

                return r;
            }
            public double prodTotalMine()
            {
                double r = 0;
                for (int i = 0; i < 100; i++)
                {
                    if (bat[i].type == 4 && bat[i].reseau == 1) r += bat[i].mine.prod_mine;
                }
                return r;
            }
            public double prodTotalScirie()
            {
                double r = 0;
                for (int i = 0; i < 100; i++)
                {
                    if (bat[i].type == 5 && bat[i].reseau == 1) r += bat[i].scierie.prod_scirie;
                }

                return r;
            }
            public double prodTotalMonument()
            {
                int r = 0;
                for (int i = 0; i < 100; i++)
                {
                    if (bat[i].type == 6) r++;
                }
                return r;
            }
            public double prodMagasin()
            {
                double r = 0;
                for (int i = 0; i < 100; i++)
                {
                    if (bat[i].type == 11 && bat[i].reseau == 1) r += bat[i].mag.prod_mag;
                }
                return r;
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

            public double comerce = 0;
            public bool comerce_bool;
            public double agriculture = 0;
            public bool agriculture_bool;
            public double exploitation = 0;
            public bool exploitation_bool;
            public double artisana = 0;
            public bool artisan_bool;
            public double culte = 0;
            public bool culte_bool;
            public double education = 0;
            public bool education_bool;
            public double calendrier = 0;
            public bool calendrier_bool;
            public double elevage = 0;
            public bool elevage_bool;
            public double cartographie = 0;
            public bool cartographie_bool;
            public double chasse = 0;
            public bool chasse_bool;
            public double exploitationMiniere = 0;
            public bool exploitationMiniere_bool;
            public double maçonnerie = 0;
            public bool maçonnerie_bool;
            public double mysticime = 0;
            public bool mysticime_bool;
            public double ecriture = 0;
            public bool ecriture_bool;

            public technologie()
            {
                comerce = 0;
                comerce_bool = false;
                agriculture = 0;
                agriculture_bool = false;
                exploitation = 0;
                exploitation_bool = false;
                artisana = 0;
                artisan_bool = false;
                culte = 0;
                culte_bool = false;
                education = 0;
                education_bool = false;
                calendrier = 0;
                calendrier_bool = false;
                elevage = 0;
                elevage_bool = false;
                cartographie = 0;
                cartographie_bool = false;
                chasse = 0;
                chasse_bool = false;
                exploitationMiniere = 0;
                exploitationMiniere_bool = false;
                maçonnerie = 0;
                maçonnerie_bool = false;
                mysticime = 0;
                mysticime_bool = false;
                ecriture = 0;
                ecriture_bool = false;
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
        public class plaine
        {

        }
        public class batiment
        {
            public gardeManger gardeManger;
            public entrepos entrepos;
            public maison maison;
            public route route;
            public ferme ferme;
            public mine mine;
            public scierie scierie;
            public monument monu;
            public ecole ecole;
            public maison2 maison2;
            public magasin mag;
            public int type;
            public int reseau;


            public batiment(int t)
            {
                type = t;
                reseau = 0;
                mag = new magasin(10, 5, 1);
                maison = new maison(10);
                route = new route(10);
                ferme = new ferme(10, 10, 1);
                mine = new mine(12, 12, 1);
                scierie = new scierie(12, 12, 1);
                monu = new monument(100, 100, 100);
                ecole = new ecole(20, 20, 20);
                entrepos = new entrepos(10, 5, 10);
                gardeManger = new gardeManger(10, 5, 10);
                maison2 = new maison2(10);
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
            if (plateau.tech.agriculture >= 10 && !plateau.tech.agriculture_bool)
            {
                Form3.label1.BackColor = Color.BlueViolet;
                MessageBox.Show("technologie terminer");
                Form3.select = 2;
                plateau.tech.agriculture_bool = true;
            }
            if (plateau.tech.exploitation >= 10 && !plateau.tech.exploitation_bool)
            {
                Form3.label3.BackColor = Color.BlueViolet;
                MessageBox.Show("technologie terminer");
                Form3.select = 3;
                plateau.tech.exploitation_bool = true;
            }
            if (plateau.tech.artisana >= 10 && !plateau.tech.artisan_bool)
            {
                Form3.label3.BackColor = Color.BlueViolet;
                MessageBox.Show("technologie terminer");
                Form3.select = 4;
                plateau.tech.artisan_bool = true;
            }
            if (plateau.tech.culte >= 10 && !plateau.tech.culte_bool)
            {
                Form3.label4.BackColor = Color.BlueViolet;
                MessageBox.Show("technologie terminer");
                Form3.select = 5;
                plateau.tech.culte_bool = true;
            }
            if (plateau.tech.education >= 10 && !plateau.tech.education_bool)
            {
                Form3.label5.BackColor = Color.BlueViolet;
                MessageBox.Show("technologie terminer");
                Form3.select = 6;
                plateau.tech.education_bool = true;
            }
            if (plateau.tech.calendrier >= 10 && !plateau.tech.calendrier_bool)
            {
                Form3.label6.BackColor = Color.BlueViolet;
                MessageBox.Show("technologie terminer");
                Form3.select = 7;
                plateau.tech.calendrier_bool = true;
            }
            if (plateau.tech.elevage >= 10 && !plateau.tech.elevage_bool)
            {
                Form3.label7.BackColor = Color.BlueViolet;
                MessageBox.Show("technologie terminer");
                Form3.select = 8;
                plateau.tech.elevage_bool = true;
            }
            if (plateau.tech.cartographie >= 10 && !plateau.tech.cartographie_bool)
            {
                Form3.label8.BackColor = Color.BlueViolet;
                MessageBox.Show("technologie terminer");
                Form3.select = 9;
                plateau.tech.cartographie_bool = true;
            }
            if (plateau.tech.chasse >= 10 && !plateau.tech.chasse_bool)
            {
                Form3.label9.BackColor = Color.BlueViolet;
                MessageBox.Show("technologie terminer");
                Form3.select = 10;
                plateau.tech.chasse_bool = true;
            }
            if (plateau.tech.exploitationMiniere >= 10 && !plateau.tech.exploitationMiniere_bool)
            {
                Form3.label10.BackColor = Color.BlueViolet;
                MessageBox.Show("technologie terminer");
                Form3.select = 11;
                plateau.tech.exploitationMiniere_bool = true;
            }
            if (plateau.tech.maçonnerie >= 10 && !plateau.tech.maçonnerie_bool)
            {
                Form3.label11.BackColor = Color.BlueViolet;
                MessageBox.Show("technologie terminer");
                Form3.select = 12;
                plateau.tech.maçonnerie_bool = true;
            }
            if (plateau.tech.mysticime >= 10 && !plateau.tech.mysticime_bool)
            {
                Form3.label12.BackColor = Color.BlueViolet;
                MessageBox.Show("technologie terminer");
                Form3.select = 13;
                plateau.tech.mysticime_bool = true;
            }
            if (plateau.tech.ecriture >= 10 && !plateau.tech.ecriture_bool)
            {
                Form3.label13.BackColor = Color.BlueViolet;
                MessageBox.Show("technologie terminer");
                Form3.select = 14;
                plateau.tech.ecriture_bool = true;
            }
            if (Form3.select == 1) plateau.tech.agriculture += plateau.technologie;
            else if (Form3.select == 2) plateau.tech.exploitation += plateau.technologie;
            else if (Form3.select == 3) plateau.tech.artisana += plateau.technologie;
            else if (Form3.select == 4) plateau.tech.culte += plateau.technologie;
            else if (Form3.select == 5) plateau.tech.education += plateau.technologie;
            else if (Form3.select == 6) plateau.tech.calendrier += plateau.technologie;
            else if (Form3.select == 7) plateau.tech.elevage += plateau.technologie;
            else if (Form3.select == 8) plateau.tech.cartographie += plateau.technologie;
            else if (Form3.select == 9) plateau.tech.chasse += plateau.technologie;
            else if (Form3.select == 10) plateau.tech.exploitationMiniere += plateau.technologie;
            else if (Form3.select == 11) plateau.tech.maçonnerie += plateau.technologie;
            else if (Form3.select == 12) plateau.tech.mysticime += plateau.technologie;
            else if (Form3.select == 13) plateau.tech.ecriture += plateau.technologie;
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
            if (plateau.bat[cas_modifier].type == 1)
            {
                if (Form4.select == 1)
                {
                    plateau.bat[cas_modifier].type = 10;
                    plateau.population_max += 5;
                    tableLayoutPanel1.Controls[cas_modifier].BackgroundImage = LesColons.Properties.Resources.maison2;
                    tableLayoutPanel1.Controls[cas_modifier].BackgroundImageLayout = ImageLayout.Stretch;
                }
            }
            int i = 0;
            while (i < 100)
            {
                if (plateau.bat[i].reseau == 0)
                {
                    if (i + 1 < 100 && plateau.bat[i + 1].reseau == 1 && plateau.bat[i + 1].type == 2) plateau.bat[i].reseau = 1;
                    if (i - 1 >= 0 && plateau.bat[i - 1].reseau == 1 && plateau.bat[i - 1].type == 2) plateau.bat[i].reseau = 1;
                    if (i - 10 >= 0 && plateau.bat[i - 10].reseau == 1 && plateau.bat[i - 10].type == 2) plateau.bat[i].reseau = 1;
                    if (i + 10 < 100 && plateau.bat[i + 10].reseau == 1 && plateau.bat[i + 10].type == 2) plateau.bat[i].reseau = 1;

                }
                i++;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 = new Form2(this);
            Form2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 = new Form3(this);
            Form3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 = new Form5(this);
            Form5.Show();
        }
    }
}
