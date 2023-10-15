using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActerGroup.Services;

public class FileService
{
    private static readonly string filePath = @"c:\Code\actermembers.json";
    public static void SaveToFile(string filePath, string contentAsJson)
    {
        using var sw = new StreamWriter(filePath);
        sw.Write(contentAsJson);
    }

    /*Klassen fileservice anropar metoden savetofile och sökvägarna filepath och contentAsJson för att kunna spara ner inne-
     hållet i min meny till en lista och mappa den listan till en lokal map på datorn för att sedan kunna plockas upp vid ett 
    annat tillfälle. Metoden ReadFromFile undersöker om det finns någon information i listan att plocka fram. Och plockar sedan
    fram det innehåll som eventuellt finns. */

    public static string ReadFromFile()
    {
        if (File.Exists(filePath))
        {
            using var sr = new StreamReader(filePath); 
            return sr.ReadToEnd();
        }
        return null!;

    }

}
