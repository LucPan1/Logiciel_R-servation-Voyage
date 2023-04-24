using exo1.Formulaire;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exo1
{
    public partial class Form1 : Form
    {
        Voyage unVoyage = new Voyage("Bali", 1800, 100, new Date(15, 09, 2022), new Date(29, 09, 2022), 25);
        Voyage unDeuxiemeVoyage = new Voyage("Guatemala", 2600, 55, new Date(23, 05, 2024), new Date(26, 05, 2024), 150);
        List<Voyage> listVoyage = new List<Voyage>();
        /*lV.Add(unVoyage);   (lV[0])
        foreach(Voyage v in lV){
            V. ________
            }*/
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //listVoyage = Serialise.chargement();

            /*listVoyage = new List<Voyage>();
            Date debut, fin;

            debut = new Date(15, 09, 22);
            fin = new Date(29, 09, 22);
            listVoyage.Add(new Voyage("Bali", 1800, 145, debut, fin, 25));


            debut = new Date(23, 05, 24);
            fin = new Date(26, 05, 24);  
            listVoyage.Add(new Voyage("Guatemala", 2600, 55, debut, fin, 150));
            */
            //  listVoyage.Add(unVoyage);
            //  listVoyage.Add(unDeuxiemeVoyage);

            listVoyage = Serialise.chargement();


            listBox1.DataSource = listVoyage;
            listBox1.ForeColor = Color.Blue;
            listBox1.ClearSelected();
            groupBox1.Visible = false;

            afficher();
        }

        private void afficher()
        {
            listBox1.DataSource = null;
            listBox1.DataSource = listVoyage;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = listBox1.SelectedIndex;

            if (i != -1)
            {

                labelArrivee.Text = listVoyage[i].getArrive().ToString();
                labelDepart.Text = listVoyage[i].getDepart().ToString();
                labelDestination.Text = listVoyage[i].getDestination();
                labelNbPlaceDispo.Text = listVoyage[i].getNbPlacesDispos().ToString();
                labelPrix.Text = listVoyage[i].getPrix().ToString();
                groupBox1.Visible = true;
                //labelPlacesAReserver.Visible = true;
                //nbPersonnesChoisi.Visible = true;
              

            }
        }

        private void buttonConfirmer_Click(object sender, EventArgs e)
        {

            int i = listBox1.SelectedIndex;

            Voyage v1 = listVoyage[i];

            Form2 fResa = new Form2(v1);
            fResa.ShowDialog();

            listBox1.SetSelected(i, true);

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Serialise.sauvegarde(listVoyage);
            
        }
    }
}
