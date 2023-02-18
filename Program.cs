using cadeteria;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllersWithViews();


//var connectionString = builder.Configuration.GetConnectionString("SqliteConnection");
builder.Services.AddSqlite<DataContext>("Data Source = cadeteria.db;");
//builder.Services.AddDbContext<DataContext>(options => options.UseSqlite(connectionString));

builder.Services.AddScoped<ICadeteRepository, CadeteRepository>();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action=Index}/{id?}");

app.MapFallbackToFile("index.html"); ;

app.Run();
