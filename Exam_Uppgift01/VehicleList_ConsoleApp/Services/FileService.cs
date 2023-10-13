namespace VehicleList_ConsoleApp.Services;

public class FileService
{
    private static readonly string _filePath = @"c:\Nackademin\C-Sharp\JsonFiles\NewVehicleList.json";
    public static async Task SaveToFileAsync(string content)
    {
        using StreamWriter sw = new StreamWriter(_filePath);
        await sw.WriteLineAsync(content);
    }

    public static string ReadFromFile()
    {
        if (File.Exists(_filePath))
        {
            using StreamReader sr = new StreamReader(_filePath);
            return sr.ReadToEnd();
        }

        return null!;
    }
}
