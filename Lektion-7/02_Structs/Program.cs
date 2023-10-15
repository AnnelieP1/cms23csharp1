//Strukter kan användas i stället för klasser. Det är en enklare form än vad klasser är. 
//När används strukter? Tex matematiska modeller. 
using _02_Structs.Structs.Domain_Driven_Design;
using _02_Structs.Structs.Interoperability;
using _02_Structs.Structs.Mathematical_Models;
using _02_Structs.Structs.Value_Semantic;
using System.Numerics;
/*Matematiska Modeller*/
Vector2D vector = new Vector2D(3.0, 4.0);
Console.WriteLine($"Vector: X={vector.X}, Y={vector.Y}");
Console.ReadKey();


/*prestanda-känsliga Applikationer*/
RgbColor color = new RgbColor(255, 0, 0);
Console.WriteLine($"Color: R={color.R}, G={color.G}, B={color.B}");
Console.ReadKey();

/*Värdesemantik */
Money salary = new Money(5000M, "SEK");
Console.WriteLine($"Money: Amount={salary.Amount},Currency={salary.Currency}");
Console.ReadKey();

/*Domain Driven Design (DDD)*/
User user = new User 
{ 
    FirstName = "Annelie",
    LastName = "Pettersson",
    Email = new Email("gydano1@hotmail.com"),
    Password = new Password("BytMig123!!!")
    
};
Console.WriteLine($"{user.FirstName} {user.LastName} <{user.Email}>");
Console.ReadKey();