``` mermaid
classDiagram
    namespace EvaluationList {
        class Mark {
            <<Enum>>
            +Unacceptable
            +Acceptable
            +Good
            +Great
        }

        class AbstractCriteriaList {
            -Guid Id
            +AbstractCriteriaList(string id)
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

    namespace Person {
        class FullName {
            -string Name
            -string Surname
            -string Patronymic
            +FullName(string name, string surname, string patronymic)
            +GetName() string
            +GetSurname() string
            +GetPatronymic() string
        }

        class AbstractPerson {
            -FullName FullName
            -uint Age
            +AbstractPerson(FullName fullName, uint age)
            +GetFullName() FullName
            +GetAge() uint
        }

        class AbstractParticipant {
            -Guid Id
            -Guid GroupId
            AbstractParticipant(string id, string groupId, FullName fullName, uint age)
            +GetId() Guid
            +GetGroupId() Guid
            +SetGroupId() void
        }

        class Participant {
            +Participant(string id, string groupId, FullName fullName, uint age)
        }

        class Expert {
            +Expert(string id, string groupId, FullName fullName, uint age)
        }
    }
    FullName <--* AbstractPerson
    AbstractPerson <--* AbstractParticipant
    AbstractParticipant <--* Participant
    AbstractParticipant <--* Expert

    namespace Group {
        class Direction {
            <<Enum>>
            +Robotics
            +Programming
            +Design
        }

        class AbstractGroup {
            -Guid Id
            -Guid CriteriaListId
            -string Name
            -Direction Direction
            -HashSet~Participant~ Participants
            -HashSet~Expert~ Experts
            +AbstractGroup(string name, Direction direction, string id, string criteriaListId)
            +GetId() Guid
            +GetCriteriaListId() Guid
            +GetName() string
            +GetParticipants() HashSet~Participant~
            +GetExperts() HashSet~Expert~
        }
    }
    Direction <--o AbstractGroup

    namespace Handler {
        class FileHandler {
            <<Interface>>
            #readData~T~(string filePath) List~T~
            #writeData~T~(string filePath, List~T~ data) void
        }

        class JsonHandler {
            +readData~T~(string filePath) List~T~
            +writeData~T~(string filePath, List~T~ data) void
        }
    }
    FileHandler <|.. JsonHandler

```
