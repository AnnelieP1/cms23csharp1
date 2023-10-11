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

    public static string ReadFromFile(string? result)
    {
        if (File.Exists(filePath))
        {
            using var sr = new StreamReader(filePath); 
            return sr.ReadToEnd();
        }
        return null!;

    }

    public static void SaveToFile(string _acter, object fullname)
    {
        throw new NotImplementedException();
    }


}
