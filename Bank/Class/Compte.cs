using System;
namespace Bank.Class
{
    public abstract class Compte
    {
        protected double Solde { get; set; }
        protected string NumeroCompte { get; set; }

        public abstract void Debiter(double montant);
        public  void Crediter(double montant)
        {
            this.Solde += montant;
        }
    }
}

