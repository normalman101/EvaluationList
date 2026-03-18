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
            -Mark _presentation
            -Mark _performance
            -Mark _themeCompatibility
            -Mark _relevance
            -Mark _novelty
            +PerformanceProfile(Mark presentation, Mark preformance, Mark themeCompatibility, Mark relevance, Mark novelty)
            +GetPresentation() Mark
            +GetPerformance() Mark
            +GetThemeCompatibility() Mark
            +GetRelevance() Mark
            +GetNovelty() Mark
        }

        class TechnicalProfile {
            -Mark _workability
            -Mark _actionAccuracy
            -Mark _materialVariety
            -Mark _softwareComplexity
            -Mark _hardwareComplexity
            -Mark _hardwareAesthetic
            -Mark _technicalSolutionLiteracy
            -Mark _technicalUsability
            +TechnicalProfile(Mark workability, Mark actionAccuracy, Mark materialVariety, Mark softwareComplexity, Mark hardwareComplexity, Mark hardwareAesthetic, Mark technicalSoultionLiteracy, Mark technicalSolution)
            +GetWorkability() Mark
            +GetActionAccuracy() Mark
            +GetMaterialVariety() Mark
            +GetSoftwareComplexity() Mark
            +GetHardwareComplexity() Mark
            +GetHardwareAesthetic() Mark
            +GetTechnicalSolutionLiteracy() Mark
            +GetTechnicalUsability() Mark
        }

        class Evaluation {
            -Guid _id
            -PerformanceProfile _performanceProfile
            -TechnicalProfile _technicalProfile
            -string _expertOpinion
            +Evaluation(PerformanceProfile performanceProfile, TechnicalProfile, technicalProfile, string expertOpinion)
            +GetPerformanceProfile() PerformanceProfile
            +GetTechnicalProfile() TechnicalProfile
            +GetExpertOpinion() string
        }

        class Evaluations {
            -List~Evaluation~ _evaluations
            +Evaluations()
            +GetEvaluations() List~Evaluation~
            +GetEvaluation(string id) Evaluation
            +AddEvaluation(Evaluation evaluation) void
            +UpdateEvaluation(string id, Evaluation newEvaluation) void
            +DeleteEvaluation(string id) void
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
            #readData~T~(string filePath) T
            #writeData~T~(string filePath, T data) bool
        }

        class JsonHandler {
            +readData~T~(string filePath) T
            +writeData~T~(string filePath, T data) bool
        }
    }
    FileHandler <|.. JsonHandler
```