namespace AspCoreDependencyInjectionWebApplication
{
    public interface ICounter
    {
        int Next { get; }
    }

    public class RandomCounter : ICounter
    {
        static Random random = new Random();
        int next;

        public RandomCounter() => next = random.Next(100);

        public int Next
        {
            get => next;
        }
    }

    public class CounterService
    {
        public ICounter Counter { get; }
        public CounterService(ICounter counter)
        {
            Counter = counter;
        }
    }
}
