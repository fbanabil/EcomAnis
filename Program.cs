var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
app.UseHttpsRedirection();

app.MapGet("/hello",()=>
{
    return "Hello from get method";
});

app.Run();
