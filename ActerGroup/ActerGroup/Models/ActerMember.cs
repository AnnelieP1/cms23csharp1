using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActerGroup.Models;

public class ActerMember
{
    public string? ActerGroupName { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Email {  get; set; } 
    public string? FullName => $"{ActerGroupName} {FirstName} {LastName} <{Email}>";

}
/*
 Här vill jag bestämma hur min medlem i Skådespelargruppen ska ha för identitet. Jag vill ha ett gruppnamn för att lättare
kunna identifiera medlemmen och senare kunna lista upp olika grupper med rätt tillhörande medlem i varje grupp. Jag vill ha förnamn
efternamn och email. Jag vill binda ihop alla dessa till ett fullname för att säkerställa att jag får fram rätt medlem och inte 
tex senare raderar fel medlem som tex råkar ha samma förnamn eller efternamn och befinna sig i samma grupp. Risken att någon har 
samma email är obefintlig och jag borde kunna ha det som identifierare men risken att någon med ett liknande email raderas finns. 
Genom att göra så här säkrar jag upp att jag verkligen får rätt medlem utan att behöva sätta ett personligt ID eller använda en 
säkrare identifieringskod. */ 