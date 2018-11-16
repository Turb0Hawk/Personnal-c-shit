using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L5RDiceRoller
{
    class Dee
    {
        private static String[] resultatsPossibleD6 = { "rien", "Opportunité + Strife", "Opportunité", "Succès + Strife",
            "Succès", "Succès explosif + Strife" };
        private static String[] resultatsPossibleD12 = { "rien", "rien", "Opportunité", "Opportunité", "Opportunité",
            "Succès + Strife", "Succès + Strife", "Succès", "Succès", "Succès + Opportunité", "Succès + Opportunité",
            "Succès explosif + Strife", "Succès explosif" };
        //6 pour d6 11 et 12 pour d12

        private int resultat;
        private int typeDee;
        private String resultDee = "";

        public Dee()
        {

        }

        public Dee(int typeDee)
        {

            this.typeDee = typeDee;
            rollDee();
        }

        void rollDee()
        {
            Random rdm = new Random();
            this.resultat = rdm.Next(this.typeDee);
            if (this.typeDee == 6)
            {
                this.resultDee += this.resultat + " " + resultatsPossibleD6[this.resultat];
            }
            else
            {
                this.resultDee = this.resultat + " " + resultatsPossibleD12[this.resultat];
            }
            if ((this.typeDee == 6 && this.resultat == 6) || (this.typeDee == 12 && this.resultat >= 11))
            {
                rollDee();
            }
        }

        public override string ToString()
        {
            return this.resultDee;
        }
    }
}
