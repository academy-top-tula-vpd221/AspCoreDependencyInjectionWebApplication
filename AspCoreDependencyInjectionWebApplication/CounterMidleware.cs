namespace AspCoreDependencyInjectionWebApplication
{
    public class CounterMidleware
    {
        //CounterService service;
        RequestDelegate next;
        int requestCount = 0;

        public CounterMidleware(RequestDelegate next)
        {
            this.next = next;
            //this.service = service;
        }

        public async Task InvokeAsync(HttpContext context, ICounter counter)
        {
            CounterService service = context.RequestServices.GetService<CounterService>();
            requestCount++;
            await context.Response.WriteAsync($"Request: {requestCount}; Counter: {counter.Next}; Service: {service.Counter.Next}");
        }
    }
}
