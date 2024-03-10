using AspCoreDependencyInjectionWebApplication;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddTransient<ICounter, RandomCounter>();
builder.Services.AddTransient<CounterService>();

//builder.Services.AddTransient<LongTimeService>();
//builder.Services.AddLongTime();

//var services = builder.Services;
//builder.Services.AddMvc();

var app = builder.Build();

//app.Run(async context =>
//{
//    var str = new StringBuilder();
//    str.Append("<h1>Services</h1>");
//    str.Append("<table>");
//    str.Append("<tr><td>type</td><td>life time</td><td>implementation</td></tr>");

//    foreach (var s in services)
//    {
//        str.Append("<tr>");
//        str.Append($"<td>{s.ServiceType.FullName}</td>");
//        str.Append($"<td>{s.Lifetime}</td>");
//        str.Append($"<td>{s.ImplementationType?.Name}</td>");
//        str.Append("</tr>");
//    }

//    str.Append("</table>");


//    context.Response.ContentType = "text/html; charset=utf-8";
//    context.Response.WriteAsync(str.ToString());
//});

//app.Run(async context => 
//{ 
//    var timeService = app.Services.GetService<LongTimeService>();
//    await context.Response.WriteAsync($"Time: {timeService?.GetTime()}");
//});

app.UseMiddleware<CounterMidleware>();

app.Run();
