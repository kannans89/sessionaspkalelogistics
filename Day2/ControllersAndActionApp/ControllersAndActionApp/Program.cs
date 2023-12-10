using ControllersAndActionApp.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<IDataService,DataService>();
builder.Services.AddControllersWithViews();
var app = builder.Build();


//dynamic x;//Unkown
//x = 100;
//x = "hello";
//Console.WriteLine(x.ToUpper());




app.UseStaticFiles();
//app.MapDefaultControllerRoute();
app.MapControllerRoute(name: "Default",
    pattern: "{controller}/{action}/{id?}",
    defaults: new { controller = "Home",
        action = "Index" });

app.Run();
