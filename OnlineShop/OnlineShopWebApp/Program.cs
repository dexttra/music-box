using OnlineShopWebApp.Models;
using Serilog;
using Microsoft.EntityFrameworkCore;
using OnlineShop.Db;



var builder = WebApplication.CreateBuilder(args);

builder.Host.UseSerilog((context, configuration) => configuration
.ReadFrom.Configuration(context.Configuration)
.Enrich.WithProperty("ApplicationName", "Music Box"));
string connection = builder.Configuration.GetConnectionString("online_shop");

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddTransient<IProductsRepository, ProductsDbRepository>();
builder.Services.AddSingleton<ICartsStorage, CartsInMemoryStorage>();
builder.Services.AddSingleton<IOrdersStorage, OrdersInMemoryStorage>();
builder.Services.AddSingleton<IRolesStorage, RolesInMemoryStorage>();
builder.Services.AddSingleton<IUsersManager, UsersManager>();
builder.Services.AddDbContext<DatabaseContext>(options => options.UseSqlServer(connection));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Home/Error");
	// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
	app.UseHsts();
}

app.UseSerilogRequestLogging();

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
	name: "MyArea",
	pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
	name: "default",
	pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
