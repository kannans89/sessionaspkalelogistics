var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();
builder.Services.AddControllersWithViews();
var app = builder.Build();

app.UseStaticFiles();
app.MapRazorPages();
app.MapDefaultControllerRoute();//{controller}/{action}
                   //HomeController/IndexAction


app.Run();
