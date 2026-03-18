namespace EvaluationList.Core.FileHandler;
using System.Text.Json;

public class JsonHandler : IFileHandler
{
    public T ReadData<T>(string filePath)
    {
        // if (string.IsNullOrWhiteSpace(filePath)) throw new Exception("Incorrect file path");
        // var jsonFile = File.ReadAllText(filePath);
        //TODO: реализовать до конца
    }

    public bool WriteData<T>(string filePath, T data)
    {
        throw new NotImplementedException();
    }
}