
namespace ExerciseSolid.Appenders.Contracts
{
    using ExerciseSolid.Loggers.Enums;

    public interface IAppender
    {
        void Append(string dateTime, ReportLevel reportLevel, string message);

        ReportLevel ReportLevel { get; set; }

        int MessagesCount { get; }
    }
}
