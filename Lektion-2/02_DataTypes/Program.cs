// skriva kommentarer
/*
 * C# standard datatyper som används
 * _______________________________________________________________________
 *string             till för text                string name = "Annelie";
 *
 *int                 till för heltal              int age = 44;
 *long                till för heltal              long age = 44;
 *
 *decimal             till för decimaltal          decimal length = 164.5m;  
 *double              till för decimaltal          double length = 164.5;
 *float               till för decimaltal          float length = 164.6f;
 *
 *bool                till för sant/falskt         bool isHuman = true; 
 *
 *char                till för enskilt tecken      char gender = 'F';
 *
 *dynamic             kan innehålla vad som        dynamic lastname = "Pettersson";
 *                                                 dynamic weight = 89.0;
 *                                                 
 *Guid                globalt unikt id             Guid id = Guid.NewGuid();                                                
 *byte                                                                                              
 *null
 *object
 *
 *-string
 *-int
 *-dacimal
 *-bool 
 *-Guid
 *-null
 *- kunna som rinnande vatten
  */

/* Deklarera variabler i C#
 __________________________________________________________________________________

camelCase                   firstName                       string firstName = "Annelie";
Pascal                      FirstName                       string FirstName = "Annelie";
kebab-case                  first-name                      string first-name = "Annelie";
snake_case                  first_name                      string first_name = "Annelie";

C# använder sig primärt av Pascal men även camelCase

korrekt sätt att deklarera´:                string firstName = "Annelie";
latmanssättet att deklarera:                var firstName = "Annelie";

*/

/*
 * STRING- textbaserade värden
 * ______________________________________________________________________________
 * 
 * string firstName = "Annelie";
 * var lastName = "Pettersson";
 * 
 * kod ska skrivas på engelska får inte skrivas på svenska
 * 
 * 
string firstName = "Annelie";
var lastName = "Pettersson";

string sentence_1 = "Jag heter Annelie och jag är bäst.";
string sentence_2 = "Jag heter Annelie och jag är \"bäst\".";

string url_1 = "c:\\education\\cms23-csharp";
string url_2 = @"c:\education\cms23-csharp";

string placeholder_1 = "Hej jag heter " + firstName + " " + lastName + ".";
string placeholder_2 = $"Hej jag heter $ {firstName} {lastName}."; //rekommenderas att använda denna. //
string placeholder_3 = string.Format("Hej jag heter {0} {1}.", firstName, lastName);
 * 
 * 
 * 
 */

Console.Write("Skriv ditt förnamn: ");
string firstName = Console.ReadLine() ?? "";

Console.Write("Skriv ditt efternamn: ");
string lastName = Console.ReadLine() ?? string.Empty;

Console.WriteLine($"Hej {firstName} {lastName}.");
Console.ReadKey();
