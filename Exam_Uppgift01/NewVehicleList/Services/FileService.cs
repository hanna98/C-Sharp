using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace NewVehicleList.Services;

public class FileService
{
    private static readonly string _filePath = @"c:\Nackademin\C-Sharp\JsonFiles\NewVehicleList.json";

    public static void SaveToFile(string content)
    {
        try
        {
            using StreamWriter sw = new StreamWriter(_filePath);
            sw.Write(content);
        }
        catch (Exception ex) { Debug.WriteLine(ex.Message); }
    }

    public static string ReadFromFile() 
    {
        try
        {
            if (File.Exists(_filePath))
            {
                using StreamReader sr = new StreamReader(_filePath);
                return sr.ReadToEnd();
            }
        }
        catch (Exception ex) { Debug.WriteLine(ex.Message); }
        
        return null!;
    }
}
