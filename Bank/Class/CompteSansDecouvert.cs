using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Class
{
    public class CompteSansDecouvert:Compte
    {
        public CompteSansDecouvert(double s, string numCompte) : base(s, numCompte)
        {

        }

        public override void Debiter(Double montant)
        {
            if (montant < 0)
            {
                throw new ArgumentException("Le montant ne peut pas être inférieur à 0");
            }
            else if (Solde - montant < 0)
            {
                Console.WriteLine("Vous ne pouvez pas être à découvert");
            }
            else
            {
                Double resultat = Solde - montant;
                Console.WriteLine("Votre solde est de " + resultat);
            }
        }

    }
}
