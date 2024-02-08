using Bank.Class;

public class Banque
{
    public List<Client> Clients { get; set; }

    public Banque()
    {
        Clients = new List<Client>();
    }

    public void Retrait(string numCompte, string numClient, double montant)
    {
        Client? client = Clients.FirstOrDefault(c => c.Nom == numClient);
        if (client is null)
        {
            throw new ArgumentException("Client introuvable.");
        }

        Compte? compte = client.Comptes.FirstOrDefault(c => c.GetNumeroCompte() == numCompte);
        if (compte is null)
        {
            throw new ArgumentException("Compte introuvable.");
        }

        compte.Debiter(montant);
    }

    public void Depot(string numCompte, string nomClient, double montant)
    {
        if (montant <= 0)
        {
            throw new ArgumentException("Le montant du dépôt doit être supérieur à zéro.");
        }

        Client? client = Clients.FirstOrDefault(c => c.Nom == nomClient);
        if (client == null)
        {
            throw new ArgumentException("Client introuvable.");
        }

        Compte? compte = client.Comptes.FirstOrDefault(c => c.GetNumeroCompte() == numCompte);
        if (compte == null)
        {
            throw new ArgumentException("Compte introuvable.");
        }

        compte.Crediter(montant);
    }
    public void OuvertureCompte(string nomClient) { /* A faire */ }
    public double Consultation(string numCompte) { /* A faire */ return 0; }
    public double ConversionFromEuro(double montant) { /* A faire */ return 0; }
    public double ConversionToEuro(double montant) { /* A faire */ return 0; }
}