using Bank.Class;

namespace Bank.Tests;

[TestClass]
public class BanqueTests
{
    private Banque banque;
    private Client client;
    private CompteSansDecouvert compte;

    [TestInitialize]
    public void Setup()
    {
        // Initialisation de la banque et ajout d'un client et d'un compte pour les tests
        banque = new Banque();
        client = new Client("123", "123 Avenue des Champs-Élysées", "Jean Dupont");
        compte = new CompteSansDecouvert(1500.0D, "FR7612345987650123456789014");
        client.Comptes.Add(compte);
        banque.Clients.Add(client);
    }

    [TestMethod]
    public void Depot_Valide_ShouldIncreaseSolde()
    {
        // Arrange
        double montantInitial = compte.Solde;
        double montantDepot = 100.0;

        // Act
        banque.Depot(compte.NumeroCompte, client.Nom, montantDepot);

        // Assert
        Assert.AreEqual(montantInitial + montantDepot, compte.Solde);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void Depot_MontantNegatif_ShouldThrowArgumentException()
    {
        // Act
        banque.Depot(compte.NumeroCompte, client.Nom, -50.0);
    }

    [TestMethod]
    public void Retrait_Valide_ShouldDecreaseSolde()
    {
        // Arrange
        double montantInitial = compte.Solde;
        double montantRetrait = 50.0;
        compte.Crediter(100); // Assurez-vous qu'il y a assez d'argent pour le retrait

        // Act
        banque.Retrait(compte.NumeroCompte, client.Nom, montantRetrait);

        // Assert
        Assert.AreEqual(montantInitial + 100 - montantRetrait, compte.Solde);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void Retrait_MontantNegatif_ShouldThrowArgumentException()
    {
        // Act
        banque.Retrait(compte.NumeroCompte, client.Nom, -50.0);
    }
    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void Depot_MontantZero_ShouldThrowArgumentException()
    {
        // Act
        banque.Depot(compte.NumeroCompte, client.Nom, 0);
    }
    
    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void Retrait_ClientInexistant_ShouldThrowArgumentException()
    {
        // Act
        banque.Retrait("FR7612345987650123456789014", "Client Inexistant", 100.0);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void Depot_ClientInexistant_ShouldThrowArgumentException()
    {
        // Act
        banque.Depot("FR7612345987650123456789014", "Client Inexistant", 100.0);
    }
    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void Retrait_CompteInexistant_ShouldThrowArgumentException()
    {
        // Act
        banque.Retrait("Compte Inexistant", client.Nom, 100.0);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void Depot_CompteInexistant_ShouldThrowArgumentException()
    {
        // Act
        banque.Depot("Compte Inexistant", client.Nom, 100.0);
    }
    
}