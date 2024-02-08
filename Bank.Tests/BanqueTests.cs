using System.Numerics;
using Bank.Class;
using Xunit.Sdk;

namespace Bank.Tests;

[TestClass]
public class BanqueTests
{
    private Banque _banque;
 
    [TestInitialize]
    public void Init()
    {
        _banque = new Banque();
        Client _client1 = new Client("numCli1","1 rue aux arenes", "doe");
        Client _client2 = new Client("numCli2", "34 rue aux graoully", "john");
        Compte _compte1 = new CompteAvecDecouvert(1500.0D, "cpt1", 100.0D);
        Compte _compte2 = new CompteSansDecouvert(1000.0D, "cpt2");
        _banque.Clients.Add(_client1);
        _banque.Clients.Add(_client2);

    }

    [TestMethod]
    public void Retrait_ClientEtCompteValide_MontantPositif()
    {
        double montant = 10.8D;
        _banque.Retrait("cpt1", "numCli1", montant);
        //Assert.AreEqual(soldeInitial - montantADebiter, compte.Solde);

    }

}