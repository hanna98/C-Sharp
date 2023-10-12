using Newtonsoft.Json;
using VehicleList_ConsoleApp.Interfaces;

namespace VehicleList_ConsoleApp.Services;

public class FileServices
{
    private static readonly string filePath = @"c:\Nackademin\C-Sharp\JsonFiles\vehicleList.json";

    public static async Task SaveToFileAsync(IEnumerable<IVehicles> data)
    {
        // Skapa en JSON-sträng genom att serialisera hela listan av objekt
        string json = JsonConvert.SerializeObject(data);

        if (!File.Exists(filePath))
        {
            // Om filen inte finns, skapar den ny fil och lägger till nytt innehåll i filen
            using StreamWriter sw = new(filePath);
            await sw.WriteAsync(json);
            Console.WriteLine("Fil sparad, tryck enter för att gå vidare");
        }
        else
        {
            // Om filen redan finns, lägger den till nytt innehåll i filen
            using StreamWriter sw = File.AppendText(filePath);
            await sw.WriteLineAsync(json);
            Console.WriteLine("Data sparad i existerande fil, tryck enter för att gå vidare");
        }
    }

    public static string ReadFromFile()
    {
        if (File.Exists(filePath))
        {
            using var sr = new StreamReader(filePath);
            return sr.ReadToEnd();
        }
        else
        {
            return null!;
        }
        
    }
}
