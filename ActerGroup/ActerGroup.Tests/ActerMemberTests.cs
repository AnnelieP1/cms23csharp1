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

    [Fact]
    public static void SaveToFile_ShouldSaveAllActerMembersToFile_ReturnTrue()
    {
        // Arrange
        ActerService acterService = new ActerService();
        ActerMember _acter = new ActerMember();
        FileService savetofile = new FileService()
        {

        // Act

        bool result = FileService.SaveToFile();





        // Assert



    }
    }




