using Microsoft.EntityFrameworkCore;
using Repositories;
using Repositories.Contracts;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<RepositoryContext>(options =>
{
    options.UseSqlite(builder.Configuration.GetConnectionString("sqlconnection"),
    b => b.MigrationsAssembly("Store_Web"));
});

//Eğer IRepositoryManager ile karşılaşılırsa RepositoryManager new'lenecek
builder.Services.AddScoped<IRepositoryManager, RepositoryManager>();
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();

var app = builder.Build();

app.UseStaticFiles(); //wwwroot için
app.UseHttpsRedirection();
app.UseRouting();

app.MapControllerRoute("default","{controller=Home}/{action=Index}/{id?}");

app.Run();
