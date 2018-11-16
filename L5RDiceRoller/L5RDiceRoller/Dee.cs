using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace L5RDiceRoller
{
    class Dee
    {
        private static string[] resultatsPossibleD6 = { "rien", "Opportunité + Strife", "Opportunité", "Succès + Strife",
            "Succès", "Succès explosif + Strife" };
        private static string[] resultatsPossibleD12 = { "rien", "rien", "Opportunité", "Opportunité", "Opportunité",
            "Succès + Strife", "Succès + Strife", "Succès", "Succès", "Succès + Opportunité", "Succès + Opportunité",
            "Succès explosif + Strife", "Succès explosif" };
        //6 pour d6 11 et 12 pour d12

        private int resultat;
        private int typeDee;
        private string resultDee = "";
        private Random rdm = new Random();
        private static RNGCryptoServiceProvider rngCsp = new RNGCryptoServiceProvider();

        public Dee()
        {

        }

        public Dee(int typeDee)
        {

            this.typeDee = typeDee;
            this.resultDee = rollDee(this.resultDee);
        }

        string rollDee(string result)
        {
            
            //this.resultat = this.rdm.Next(this.typeDee);
            int resultatDee = rngCsp.
            if (this.typeDee == 6)
            {
                result += " " + resultatsPossibleD6[this.resultat];
            }
            else
            {
                result += " " + resultatsPossibleD12[this.resultat];
            }
            if ((this.typeDee == 6 && this.resultat+1 == 6) || (this.typeDee == 12 && this.resultat+1 >= 11))
            {
                result += " + ";
                result = rollDee(result);
            }
            return result;
        }

        public override string ToString()
        {
            return this.resultDee;
        }
    }
}
