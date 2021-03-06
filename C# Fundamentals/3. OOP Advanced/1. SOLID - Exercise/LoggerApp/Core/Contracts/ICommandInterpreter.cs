namespace LoggerApp.Core.Contracts
{
    public interface ICommandInterpreter
    {
        void AddAppender(string[] args);
        void AddMessage(string[] args);
        void PrintInfo();
    }
}