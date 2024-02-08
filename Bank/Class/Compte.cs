public abstract class Compte
{
    public double Solde { get; set; }
    public string NumeroCompte { get; set; }

    public Compte(double s, string numCompte)
    {
        this.Solde = s;
        this.NumeroCompte = numCompte;
    }

    public abstract void Debiter(double montant);

    public void Crediter(double montant)
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