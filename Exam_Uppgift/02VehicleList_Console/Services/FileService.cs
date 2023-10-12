using System.Runtime.CompilerServices;

namespace _02VehicleList_Console.Services;

public class FileService
{
    private static readonly string filePath = @"c:\Nackademin\C-Sharp\JsonFiles\02VehicleList.json";

    public static void SaveToFile(string contentAsJson)
    {
        using var sw = new StreamWriter(filePath);
        sw.Write(contentAsJson);
    }

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
