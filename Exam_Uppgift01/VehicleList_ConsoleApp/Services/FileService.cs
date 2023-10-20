using System.Diagnostics;

namespace VehicleList_ConsoleApp.Services;

public class FileService
{
    private static readonly string _filePath = @"c:\Nackademin\C-Sharp\JsonFiles\VehicleList_CA.json";
    public static async Task SaveToFileAsync(string content)
    {
        try
        {
            using StreamWriter sw = new StreamWriter(_filePath);
            await sw.WriteLineAsync(content);
        }
        catch (Exception ex) { Debug.WriteLine(ex.Message); }
    }

    public static string ReadFromFile()
    {
        //try
        //{
            if (File.Exists(_filePath))
            {
                using StreamReader sr = new StreamReader(_filePath);
                return sr.ReadToEnd();
            }

            return null!;
        //}
        //catch (Exception ex) { Debug.WriteLine(ex.Message); }
        
    }
}
