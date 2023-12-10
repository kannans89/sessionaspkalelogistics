WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

//reigster services
WebApplication app = builder.Build();


app.Use(async (context,next) => {
    Console.WriteLine("UseA (B)"+ context.Request.Path);
     await next();
    Console.WriteLine("UseA (A)" + context.Request.Path);
});

app.Use(async (context, next) =>
{
    Console.WriteLine("UseC (B)" + context.Request.Path);
    await next();
    Console.WriteLine("UseC (A)" + context.Request.Path);
});

app.Use(async (context, next) => {
    Console.WriteLine("UseB (B)" + context.Request.Path);
    await next();
    Console.WriteLine("UseB (A)" + context.Request.Path);
});

app.Map("/howdy", (appBuilder) => {

    appBuilder.Run(async (context) => {

       await context.Response.WriteAsync("<h1>Howdy</h1>");
    });
});

app.Run(async (context) =>
{
   await  context.Response.WriteAsync("<h1>Run1 </h1>");
});
app.Run(async (context) =>
{
    await context.Response.WriteAsync("<h1>Run2 </h1>");
});

app.MapGet("/", () => "Hello World!");

//register middleware
app.Run();
