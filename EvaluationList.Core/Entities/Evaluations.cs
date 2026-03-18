namespace EvaluationList.Core.Entities;

public class Evaluations
{
    public List<Evaluation> Elements { get; } = [];

    public Evaluation? GetEvaluation(string id)
    {
        return Elements.FirstOrDefault(element => element.Id.ToString() == id);
    }

    public void AddEvaluation(Evaluation evaluation)
    {
        Elements.Add(evaluation);
    }

    public void UpdateEvaluation(string id, Evaluation newEvaluation)
    {
        var foundElement = Elements.FirstOrDefault(element => element.Id.ToString() == id);
        
        if (foundElement!.GetType() == null) throw new Exception("Element not found");
        
        Elements.Remove(foundElement);
        
        Elements.Add(newEvaluation with {Id = foundElement.Id});
    }

    public void DeleteEvaluation(string id)
    {
        Elements.RemoveAll(element => element.Id.ToString() == id);
    }
}