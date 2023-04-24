using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo1
{
    [Serializable]
    public class Resa
    {
        public Voyage leVoyage;
        public int nbPersonnes;

        public Resa(Voyage leVoyage, int nbPersonnes)
        {
            this.leVoyage = leVoyage;
            this.nbPersonnes = nbPersonnes;
        }
        public override string ToString()
        {
            return this.leVoyage.ToString() + "/" + this.nbPersonnes;
        }

        public double calculMontant()
        {
            return (leVoyage.getPrix() + leVoyage.getTaxe() * this.nbPersonnes);
        }

        public bool resaPossible()
        {
            if (this.leVoyage.getNbPlacesDispos() >= this.nbPersonnes)
            {
                return true;
            }
            return false;
        }

        public void comfirmResa()
        {
            this.leVoyage.setNbPlacesDispos(this.leVoyage.getNbPlacesDispos() - this.nbPersonnes);

        }
    }            

    }
