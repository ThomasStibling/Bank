namespace Bank.Class;

public class Client
{
    private string numClient;
    private string adresse;
    private string nom;
    private List<Compte> comptes;

    public Client(string numClient, string adresse, string nom)
    {
        this.numClient = numClient;
        this.adresse = adresse;
        this.nom = nom;
        this.comptes = new List<Compte>();
    }

    public string NumClient
    {
        get { return numClient; }
        set { numClient = value; }
    }

    public string Adresse
    {
        get { return adresse; }
        set { adresse = value; }
    }

    public string Nom
    {
        get { return nom; }
        set { nom = value; }
    }

    public List<Compte> Comptes
    {
        get { return comptes; }
    }

}