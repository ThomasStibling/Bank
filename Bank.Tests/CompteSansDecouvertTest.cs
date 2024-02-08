using Bank.Class;
using Xunit.Sdk;

namespace Bank.Tests;

[TestClass]
public class CompteSansDecouvertTest
{
    [TestMethod]
    public void Debiter_WithPositiveAmount_ShouldReduceBalance()
    {
        double soldeInitial = 1000;
        string numeroCompte = "123456";
        double montantADebiter = 500;
        CompteSansDecouvert compte = new CompteSansDecouvert(soldeInitial, numeroCompte);

        compte.Debiter(montantADebiter);

        Assert.AreEqual(soldeInitial - montantADebiter, compte.Solde);
    }

    [TestMethod]
    public void Debiter_WithNegativeAmount_ShouldThrowArgumentException()
    {
        double soldeInitial = 1000;
        string numeroCompte = "123456";
        double montantADebiter = -500;
        CompteSansDecouvert compte = new CompteSansDecouvert(soldeInitial, numeroCompte);

        Assert.ThrowsException<ArgumentException>(() => compte.Debiter(montantADebiter));
    }

    [TestMethod]
    public void Debiter_WithInsufficientBalance_ShouldNotChangeBalance()
    {
        double soldeInitial = 1000;
        string numeroCompte = "123456";
        double montantADebiter = 1500;
        CompteSansDecouvert compte = new CompteSansDecouvert(soldeInitial, numeroCompte);

        compte.Debiter(montantADebiter);

        Assert.AreEqual(soldeInitial, compte.Solde);
    }
}