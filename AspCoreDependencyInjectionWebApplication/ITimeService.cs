namespace AspCoreDependencyInjectionWebApplication
{
    public interface ITimeService
    {
        string GetTime();
    }

    class ShortTimeService : ITimeService
    {
        public string GetTime()
        {
            return DateTime.Now.ToShortTimeString();
        }
    }

    class LongTimeService : ITimeService
    {
        public string GetTime()
        {
            return DateTime.Now.ToLongTimeString();
        }
    }

    public static class LongTimeSericeExtensions
    {
        public static void AddLongTime(this IServiceCollection services)
        {
            services.AddTransient<LongTimeService>();
        }
    }

}
