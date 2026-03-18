namespace EvaluationList.Core.Entities;

public record Evaluation
{
    public Evaluation(PerformanceProfile performanceProfile, TechnicalProfile technicalProfile, string expertOpinion)
    {
        Id = Guid.CreateVersion7();
        PerformanceProfile = performanceProfile;
        TechnicalProfile = technicalProfile;
        ExpertOpinion = expertOpinion;
    }

    public Guid Id { get; init; }
    public PerformanceProfile PerformanceProfile { get; }
    public TechnicalProfile TechnicalProfile { get; }
    public string ExpertOpinion { get; }
}