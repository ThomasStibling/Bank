using Bank.Class;

namespace Bank.Tests;

[TestClass]
public class CompteTest
{
    double soldeInitial = 1000;
    string numeroCompte = "123456";

    [TestMethod]
    public void Crediter_WithPositiveAmount_ShouldIncreaseBalance()
    {
        double montantACrediter = 500;
        Compte compte = new CompteMock(soldeInitial, numeroCompte);

        compte.Crediter(montantACrediter);

        Assert.AreEqual(soldeInitial + montantACrediter, compte.Solde);
    }

    [TestMethod]
    public void Crediter_WithZeroAmount_ShouldNotChangeBalance()
    {
        double montantACrediter = 0;
        Compte compte = new CompteMock(soldeInitial, numeroCompte);

        compte.Crediter(montantACrediter);

        Assert.AreEqual(soldeInitial, compte.Solde);
    }

    [TestMethod]
    public void Crediter_WithNegativeAmount_ShouldNotChangeBalance()
    {
        double montantACrediter = -500;
        Compte compte = new CompteMock(soldeInitial, numeroCompte);

        compte.Crediter(montantACrediter);

        Assert.AreEqual(soldeInitial, compte.Solde);
    }

    private class CompteMock : Compte
    {
        public CompteMock(double s, string numCompte) : base(s, numCompte)
        {
        }

        public override void Debiter(double montant)
        {
            throw new NotImplementedException();
        }
    }
}
