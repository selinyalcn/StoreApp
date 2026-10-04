using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using StoreApp;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<RepositoryContext>(Options =>
{
    Options.UseSqlite(builder.Configuration.GetConnectionString("sqlconnection"));
});
var app = builder.Build();
app.UseStaticFiles();
app.UseHttpsRedirection();
app.UseRouting();

app.MapControllerRoute(
    name:"default",
   pattern:"{controller=Home}/{action=Index}/{id?}");

app.Run();
