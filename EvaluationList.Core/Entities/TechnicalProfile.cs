namespace EvaluationList.Core.Entities;

public record TechnicalProfile(
    Mark workability,
    Mark actionAccuracy,
    Mark materialVariety,
    Mark softwareComplexity,
    Mark hardwareComplexity,
    Mark hardwareAesthetic,
    Mark technicalSolutionLiteracy,
    Mark technicalUsability)
{
    public Mark Workability { get; } = workability;
    public Mark ActionAccuracy { get; } = actionAccuracy;
    public Mark MaterialVariety { get; } = materialVariety;
    public Mark SoftwareComplexity { get; } = softwareComplexity;
    public Mark HardwareComplexity { get; } = hardwareComplexity;
    public Mark HardwareAesthetic { get; } = hardwareAesthetic;
    public Mark TechnicalSolutionLiteracy { get; } = technicalSolutionLiteracy;
    public Mark TechnicalUsability { get; } = technicalUsability;
}