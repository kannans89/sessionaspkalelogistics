using Microsoft.EntityFrameworkCore;
using MVCWithEFApp.Data;
using MVCWithEFApp.Repository;

var builder = WebApplication.CreateBuilder(args);



var conectionString = builder.Configuration.GetConnectionString("prodDbServer");
// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<OrganizationDbContext>(options => {
    options.UseSqlServer(conectionString);
});

builder.Services.AddScoped<IOrganizationRepostiory, OrganizationEFRepository>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
