using ActerGroup.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActerGroup.Services;

public class MenuService //Här skapar jag menyn som jag navigerar mig igenom för att kunna välja vad jag vill göra i min applikation.
{
    private readonly ActerService _acterService = new ActerService(); 
    /* Jag anropar Acterservice och innehållet som finns i acterService för att kunna skapa en medlem, spara ner en medlem i en lista
     plocka fram en medlem ur listan, radera en medlem från listan, plocka fram en medlem ur listan om jag tex behöver göra en ändring. 
    */
    public void MainMenu()//Min förstasida med alla valmöjligheter. 
    {
        _acterService.GetAllActerMembers();

        var exit = false;

        do
        {
            Console.Clear();
            Console.WriteLine("Välj ett av följande alternativ (0-5): ");
            Console.WriteLine("1. Skapa en ny medlem");
            Console.WriteLine("2. Visa alla medlemmar");
            Console.WriteLine("3. Visa en specifik medlem");
            Console.WriteLine("4. Radera en medlem ur gruppen");
            Console.WriteLine("0. Avsluta");
            var option = Console.ReadLine();

            switch (option) //Här talar jag om vad jag vill ska hända vid varje valmöjlighet. Om jag väljer val nr 2 ska alla medlemmar
                            // visas väljer jag 1 ska jag skriva in de uppgifter konsollen ber mig att fylla i. OSV. 
            {
                case ("1"):
                    CreateMenu();
                    break;
                case ("2"):
                    GetAllActerMembers();

                    break;
                case ("3"):
                    GetOneActerMember();

                    break;
                case ("4"):
                    RemoveActerMember();

                    break;
                case ("0"):
                    exit = true;

                    break;
                default:
                    break;

            }

        }
        while (exit == false);

    }
    public void CreateMenu() //Här skapas den medlem som jag har bestämt utseendet på i klassen Actermember. 
    {
        Console.Clear();
        Console.WriteLine("Skapa en ny medlem");
        Console.WriteLine("------------------");


        var actermember = new ActerMember();

        Console.Write("Ange Gruppnamn: ");
        actermember.ActerGroupName = Console.ReadLine();

        Console.Write("Förnamn: ");
        actermember.FirstName = Console.ReadLine()!.Trim();

        Console.Write("Efternamn: ");
        actermember.LastName = Console.ReadLine()!.Trim();

        Console.Write("email: ");
        actermember.Email = Console.ReadLine()!.Trim().ToLower();



        _acterService.AddActerMemberToList(actermember); // Här ber jag ActerService att lägga till medlemmen i listan som jag har skapat
        Console.WriteLine("En ny teatermedlem har lagts till.");// i ActerService. 
        Console.ReadKey();


    }
    public void GetAllActerMembers() // Här ber jag ActerService plocka fram alla medlemmar från listan ActerMember som finns i ActerService. 
    {
        var actermembers = _acterService.GetAllActerMembers();
        foreach (var actermember in actermembers)
        {
            Console.WriteLine(actermember.FullName);
            Console.WriteLine();

        }
        Console.ReadKey();
    }
    public void GetOneActerMember() //Genom att ange fullname kan jag plocka fram en specifik medlem ur listan
    {
        Console.Write("Ange teatermedlemmens gruppnamn, förnamn, efternamn och emailadress: ");
        var fullname = Console.ReadLine();
        var actermember = _acterService.GetOneActerMember(fullname!);
        Console.WriteLine(actermember.FullName);
        Console.WriteLine();
        Console.ReadKey();

    }

    public void RemoveActerMember() // Här kan jag genom fullname radera en medlem från listan. 
    {
        Console.Write("Ange teatermedlemmens gruppnamn, förnamn, efternamn och emailadress: ");
        var fullname = Console.ReadLine();
        _acterService.RemoveActerMember(fullname!);


    }
}
