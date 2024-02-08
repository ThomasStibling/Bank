using System;
namespace Bank.Class
{
    public abstract class Compte
    {
        public double Solde { get; set; }
        protected string NumeroCompte { get; set; }

        public string GetNumeroCompte()
        {
            return NumeroCompte;
        }

        public double GetSolde()
        {
            return Solde;
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

