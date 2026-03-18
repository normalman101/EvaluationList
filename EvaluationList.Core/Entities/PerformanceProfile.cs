namespace EvaluationList.Core.Entities;

public record PerformanceProfile(Mark presentation, Mark performance, Mark themeCompatibility, Mark relevance, Mark novelty)
{
    public Mark Presentation { get; } = presentation;
    public Mark Performance { get; } = performance;
    public Mark ThemeCompatibility { get; } = themeCompatibility;
    public Mark Relevance { get; } = relevance;
    public Mark Novelty { get; } = novelty;
}