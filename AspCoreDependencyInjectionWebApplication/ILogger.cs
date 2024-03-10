namespace AspCoreDependencyInjectionWebApplication
{
    


    public interface ILogger
    {
        void Log(string message);
    }

    class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"{DateTime.Now.ToString()} {message}");
        }
    }

    class FileLogger : ILogger
    {
        public void Log(string message)
        {
            File.AppendAllText("log.txt", $"{DateTime.Now.ToString()} {message}");
        }
    }

    class Messanger
    {
        ILogger logger;
        public string Text { set; get; }
        public Messanger(ILogger logger)
        {
            this.logger = logger;
        }
        public void LogRun() => logger.Log(Text);
    }
}
