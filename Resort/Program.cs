using Microsoft.EntityFrameworkCore;
using Resort.Context;
using Resort.Repo.IReponsitories;
using Resort.Repo.Reponsitories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<MyContext>(options =>
{
	options.UseSqlServer(builder.Configuration.GetConnectionString("Resort"));
});

builder.Services.AddSession(options =>
{
	options.IdleTimeout= TimeSpan.FromMinutes(30);
	options.Cookie.HttpOnly= true;
	options.Cookie.IsEssential= true;
});

builder.Services.AddScoped<IUserRepo,UserRepo>();
builder.Services.AddScoped<IUserDetailRepo,UserDetailRepo>();

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

app.UseSession();

app.UseRouting();

app.UseAuthorization();

app.MapAreaControllerRoute(
	name: "Areas",
	areaName: "Admin",
	pattern: "Admin/{controller=HomeAdmin}/{action=IndexAdmin}/{id?}");

app.MapControllerRoute(
	name: "default",
	pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
