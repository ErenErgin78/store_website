using Microsoft.EntityFrameworkCore;
using Store_Web.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<RepositoryContext>(options =>
{
    options.UseSqlite(builder.Configuration.GetConnectionString("sqlconnection"));
});

var app = builder.Build();

app.UseStaticFiles(); //wwwroot için
app.UseHttpsRedirection();
app.UseRouting();

app.MapControllerRoute("default","{controller=Home}/{action=Index}/{id?}");

app.Run();
