namespace EvaluationList.Core.FileHandler;
using System.Text.Json;

public class JsonHandler : IFileHandler
{
    public List<T> ReadData<T>(string filePath)
    {
        if (!File.Exists(filePath)) throw new Exception("Specified file path doesn't exist");
        
        var jsonFile = File.ReadAllText(filePath);
        
        return JsonSerializer.Deserialize<List<T>>(jsonFile)!;
    }

    public void WriteData<T>(string filePath, List<T> data)
    {
        if (!File.Exists(filePath)) throw new Exception("Specified file path doesn't exist");

        var options = new JsonSerializerOptions()
        {
            WriteIndented = true
        };
        
        File.WriteAllText(filePath, JsonSerializer.Serialize(data, options));
    }
}