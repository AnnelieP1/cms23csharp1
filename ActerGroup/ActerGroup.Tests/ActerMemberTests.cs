using ActerGroup.Models;
using ActerGroup.Services;
using DocuSign.eSign.Model;

namespace ActerGroup.Tests;

public class ActerMemberTests
{


    [Fact]
    public void AddActerMember_ShouldAddActerMemberToList_ReturnTrue()
    {
        // Arrange - Förberedelse

        ActerService _acterService = new ActerService();
        ActerMember _acter = new ActerMember();

        // Act - Utförande

        bool result = _acterService.AddActerMemberToList(_acter);

        // Assert - Kontroll

        Assert.True(result);
    }

    /*Genom att installera ett xunit test i min applikation kan jag testa olika enhetsdelar för att säkerställa att min kod är
     korrekt och faktiskt gör det den ska. Ovan kontrollerar jag att ActerServic sparar ner den nyskapade ActerMember i den listan 
    som finns i ActerMemberklassen. */


    [Fact]
    public void AddActerMember_ShouldAddActerMemberToList_ReturnCorrectActerMemberFromList()
    {
        // Arrange - Förberedelser
        ActerService _acterService = new ActerService();
        ActerMember _acter = new ActerMember()
        {
            ActerGroupName = "Pelikanen",
            FirstName = "Annelie",
            LastName = "Pettersson",
            Email = "annelie@domain.com"
        };

        _acterService.AddActerMemberToList(_acter);

        // Act - Utförande

        var result = _acterService.GetOneActerMember(_acter.FullName!);


        // Assert - Kontroll
        Assert.NotNull(result);
        Assert.IsType<ActerMember>(result);
        Assert.Equal("Annelie", result.FirstName);

    }
}
    




