using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Class
{
    public class CompteAvecDecouvert:Compte
    {
        private double decouvertAutorise { get; set; }

        public CompteAvecDecouvert(double s, string numCompte, double decouvertAuto) : base(s, numCompte)
        {
            this.decouvertAutorise = decouvertAuto;
        }

        public override void Debiter(double montant)
        {
            if (montant < 0)
            {
                throw new ArgumentException("Le montant ne peut pas être inférieur à 0");
            }
            else if (Solde - montant < decouvertAutorise)
            {
                Solde = Solde;
            }
            else
            {
                Solde -= montant;
                Console.WriteLine("Votre solde est de " + Solde);
            }
        }

    }
}
