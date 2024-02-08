using Bank.Class;
using Xunit.Sdk;

namespace Bank.Tests;

[TestClass]
public class CompteSansDecouvertTest
{
    [TestMethod]
    public void Debiter_WithNegativeAmount_ShouldThrowArgumentException()
    {
        double soldeInitial = 1000;
        double montantADebiter = -500;
        CompteSansDecouvert compte = new CompteSansDecouvert(soldeInitial, "Test");

        Assert.ThrowsException<ArgumentException>(() => compte.Debiter(montantADebiter));
    }
}
