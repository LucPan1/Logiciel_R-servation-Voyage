using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo1
{
    [Serializable]   
    public class Date
    {
        private int jour;
        private int mois;
        private int annee;


        public Date(int jour, int mois, int annee)
        {
            this.jour = jour;
            this.mois = mois;
            this.annee = annee;
        }
        public override string ToString()
        {
            return this.jour + "/" + this.mois + "/" + this.annee;
        }
    }
}
