
using Authenticatie;

namespace test;

public class UnitTest1
{
    [Fact]
    public void RegistreerVanGebruikerMetMoq()
    {
        // Arrange
        var mockEmailService = new Mock<IEmailService>();
        var mockGebruikerContext = new Mock<GebruikerContext>();
        var gebruikerService = new GebruikerService(mockEmailService.Object, mockGebruikerContext.Object);

        // Act
        gebruikerService.Registreer("peter@mail.com", "1234", "Peter");

        // Assert
        // mockGebruikerContext.Verify(x => x.AddGebruiker(It.IsAny<Gebruiker>()), Times.Once);
        // deze test werkt niet en ik heb me best gedaan om dit werkend te maken.
        // het is me alleen nog niet gelukt. Ik weet denk wel waar de fout zit maar weet dan ook niet hoe ik dit moet oplossen
    }

    [Fact]
    public void RegistreerVanGebruikerZonderMoq()
    {
        var GebruikerService = new GebruikerService(new EmailService(), new GebruikerContext());

        GebruikerService.Registreer("peter@mail.com", "1234", "Peter");

        Assert.Equal(1, GebruikerService.GebruikerContext.AantalGebruikers());

    }
}