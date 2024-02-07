using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Class
{
    public class Banque
    {
        public List<Client> Clients { get; set; }

        public void Retrait(string numCompte, string nomClient, double montant) { /* A faire */ }
        public void Depot(string numCompte, string nomClient, double montant) { /* A faire */ }
        public void OuvertureCompte(string nomClient) { /* A faire */ }
        public double Consultation(string numCompte) { /* A faire */ return 0; }
        public double ConversionFromEuro(double montant) { /* A faire */ return 0; }
        public double ConversionToEuro(double montant) { /* A faire */ return 0; }
    }
}
