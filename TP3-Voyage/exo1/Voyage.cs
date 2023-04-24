using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo1
{
    [Serializable]
    public class Voyage
    {
        private string destination;
        private double prix;
        private double taxe;
        private Date dateDepart;
        private Date dateArrive;
        private int nbPlacesDispos;

        public string getDestination()
        {
            return this.destination;
        }

        public void setDestination(String destination)
        {
            this.destination = destination;
        }

        public Date getDepart()
        {
            return this.dateDepart;
        }

        public void setDepart(Date dateDepart)
        {
            this.dateDepart = dateDepart;
        }

        public Date getArrive()
        {
            return this.dateArrive;
        }

        public void setArrive(Date dateArrive)
        {
            this.dateArrive = dateArrive;
        }

        public double getPrix()
        {
            return this.prix;
        }

        public void setPrix(double prix)
        {
            this.prix = prix;
        }
        public double getTaxe()
        {
            return this.taxe;
        }

        public void setTaxe(double taxe)
        {
            this.taxe = taxe;
        }
        public int getNbPlacesDispos()
        {
            return this.nbPlacesDispos;
        }
       
        public void setNbPlacesDispos(int nbPlacesDispos)
        {
            this.nbPlacesDispos = nbPlacesDispos;
        }


        public Voyage(string destination, double prix, double taxe, Date dateDepart, Date dateRetour, int nbPlacesDispos)
        {
            this.destination = destination;
            this.prix = prix;
            this.taxe = taxe;
            this.dateDepart = dateDepart;
            this.dateArrive = dateRetour;
            this.nbPlacesDispos = nbPlacesDispos;
        }
        public override string ToString()
        {
            return (this.destination);
        }


    }
}
