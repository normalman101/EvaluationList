``` mermaid
 classDiagram
namespace EvaluationList {
    class Mark {
        <<Enum>>
        +UNACCEPTABLE
        +ACCEPTABLE
        +GOOD
        +GREAT
    }


    class PerformanceProfile {
        -Mark _Presentation
        -Mark _Performance
        -Mark _ThemeCompatibility
        -Mark _Relevance
        -Mark _Novelty
        +PerformanceProfile(Mark presentation, Mark preformance, Mark themeCompatibility, Mark relevance, Mark novelty)
        +getPresentation() Mark
        +getPerformance() Mark
        +getThemeCompatibility() Mark
        +getRelevance() Mark
        +getNovelty() Mark
    }

    class TechnicalProfile {
        -Mark _Workability
        -Mark _ActionAccuracy
        -Mark _MaterialVariety
        -Mark _SoftwareComplexity
        -Mark _HardwareComplexity
        -Mark _HardwareAesthetic
        -Mark _TechnicalSolutionLiteracy
        -Mark _TechnicalUsability
        +TechnicalProfile(Mark workability, Mark actionAccuracy, Mark materialVariety, Mark softwareComplexity, Mark hardwareComplexity, Mark hardwareAesthetic, Mark technicalSoultionLiteracy, Mark technicalSolution)
        +getWorkability() Mark
        +getActionAccuracy() Mark
        +getMaterialVariety() Mark
        +getSoftwareComplexity() Mark
        +getHardwareComplexity() Mark
        +getHardwareAesthetic() Mark
        +getTechnicalSolutionLiteracy() Mark
        +getTechnicalUsability() Mark
    }

    class Evaluation {
        -PerformanceProfile _PerformanceProfile
        -TechnicalProfile _TechnicalProfile
        -string _ExpertOpinion
        +Evaluation(PerformanceProfile performanceProfile, TechnicalProfile, technicalProfile, string expertOpinion)
        +getPerformanceProfile() PerformanceProfile
        +getTechnicalProfile() TechnicalProfile
        +getExpertOpinion() string
    }

    class Evaluations {
        -List~Evaluation~ _Evaluations
        +Evaluations()
        +getEvaluations() List~Evaluation~
        +getEvaluation(string id) Evaluation
        +addEvaluation(Evaluation evaluation) void
        +updateEvaluation(string id, Evaluation newEvaluation) void
        +deleteEvaluation(string id) void
    }
}
Mark <--* PerformanceProfile
Mark <--* TechnicalProfile
PerformanceProfile <--* Evaluation
TechnicalProfile <--* Evaluation
Evaluation <--o Evaluations

namespace Handler {
    class FileHandler {
        <<Interface>>
        #readData<T>(string filePath) T
        #writeData<T>(string filePath, T data) bool
    }

    class JsonHandler {
        +readData~T~(string filePath) T
        +writeData~T~(string filePath, T data) bool
    }
}
FileHandler <|.. JsonHandler
```