using System;
namespace Bank.Class
{
    public abstract class Compte
    {
        public double Solde { get; set; }
        protected string NumeroCompte { get; set; }

        public Compte(double s, string numCompte)
        {
            this.Solde = s;
            this.NumeroCompte = numCompte;
        }

        public abstract void Debiter(double montant);

        public  void Crediter(double montant)
        {
            if (montant > 0)
            {
                this.Solde += montant;
            }
            else
            {
                this.Solde += 0;
            }
            
        }
    }
}

