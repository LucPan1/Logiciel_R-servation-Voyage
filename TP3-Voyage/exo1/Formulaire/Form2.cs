using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exo1.Formulaire
{
    internal partial class Form2 : Form
    {
        Voyage monVoyage;

        Resa uneReservation;

        public Form2(Voyage v)
        {
            InitializeComponent();

            this.monVoyage = v;
        }

        private void Form2_Load(object sender, EventArgs e)
        {


            labelArr.Text = monVoyage.getArrive().ToString();
            labelDep.Text = monVoyage.getDepart().ToString();
            labelDes.Text = monVoyage.getDestination();
          
            //labelPlaceDispo.Text = monVoyage.getNbPlacesDispos().ToString();
           
            
        }

      

        private void button1_Click_1(object sender, EventArgs e)
        {
            uneReservation = new Resa(monVoyage, Convert.ToInt16(nbPersonnesChoisi.Text));

            labelMontant.Text = uneReservation.calculMontant().ToString();
            

            if (uneReservation.resaPossible())
            {

                uneReservation.comfirmResa();
                labelPlaceDispo.Text = monVoyage.getNbPlacesDispos().ToString();

            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
