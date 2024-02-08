using Xunit.Sdk;
using Bank.Class;

namespace Bank.Tests; 

[TestClass]
public class CompteAvecDecouvertTest
{
    [TestMethod]
    public void Debiter_WithPositiveAmount_ShouldReduceBalance()
    {
        double soldeInitial = 1000;
        string numeroCompte = "123456";
        double decouvertAutorise = 500;
        double montantADebiter = 300;
        CompteAvecDecouvert compte = new CompteAvecDecouvert(soldeInitial, numeroCompte, decouvertAutorise);

        compte.Debiter(montantADebiter);

        Assert.AreEqual(soldeInitial - montantADebiter, compte.Solde);
    }

    [TestMethod]
    public void Debiter_WithNegativeAmount_ShouldThrowArgumentException()
    {
        double soldeInitial = 1000;
        string numeroCompte = "123456";
        double decouvertAutorise = 500;
        double montantADebiter = -300;
        CompteAvecDecouvert compte = new CompteAvecDecouvert(soldeInitial, numeroCompte, decouvertAutorise);

        Assert.ThrowsException<ArgumentException>(() => compte.Debiter(montantADebiter));
    }

    [TestMethod]
    public void Debiter_WithExceedingOverdraft_ShouldNotChangeBalance()
    {
        double soldeInitial = 1000;
        string numeroCompte = "123456";
        double decouvertAutorise = 500;
        double montantADebiter = 1600;
        CompteAvecDecouvert compte = new CompteAvecDecouvert(soldeInitial, numeroCompte, decouvertAutorise);

        compte.Debiter(montantADebiter);

        Assert.AreEqual(soldeInitial, compte.Solde);
    }
}
