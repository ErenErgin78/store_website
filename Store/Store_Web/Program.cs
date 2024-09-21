using Microsoft.EntityFrameworkCore;
using Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<RepositoryContext>(options =>
{
    options.UseSqlite(builder.Configuration.GetConnectionString("sqlconnection"),
    b => b.MigrationsAssembly("Store_Web"));
});

var app = builder.Build();

app.UseStaticFiles(); //wwwroot için
app.UseHttpsRedirection();
app.UseRouting();

app.MapControllerRoute("default","{controller=Home}/{action=Index}/{id?}");

app.Run();
