var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
var app = builder.Build();




app.UseStaticFiles();
app.MapControllerRoute(name: "default",
    pattern: "{controller}/{action}/{id?}",
    defaults: new { controller = "Developer", action = "Index" });

app.Run();
