using Microsoft.EntityFrameworkCore;
using Resort.Context;
using Resort.Repo.IReponsitories;
using Resort.Repo.Reponsitories;
using Resort.Ser.IServices;
using Resort.Ser.Services;

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
builder.Services.AddScoped<ICommuneRepo,CommuneRepo>();
builder.Services.AddScoped<IProvinceRepo,ProvinceRepo>();
builder.Services.AddScoped<IDistrictRepo,DistrictRepo>();
builder.Services.AddScoped<IResortRepo,ResortRepo>();
builder.Services.AddScoped<IResortDetailRepo, ResortDetailRepo>();
builder.Services.AddScoped<IResortDetailServicesRepo,ResortDetailServicesRepo>();
builder.Services.AddScoped<IRateRepo,RateRepo>();
builder.Services.AddScoped<IRoleRepo,RoleRepo>();
builder.Services.AddScoped<IConvenientRepo,ConvenientRepo>();
builder.Services.AddScoped<IServiceRepo,ServiceRepo>();
builder.Services.AddScoped<ITypeRoomRepo,TypeRoomRepo>();
builder.Services.AddScoped<ITypeRoomResortDetailRepo,TypeRoomResortDetailRepo>();
builder.Services.AddScoped<IConvenientResortRepo,ConvenientResortRepo>();

builder.Services.AddScoped<IUserSer, UserSer>();
builder.Services.AddScoped<IUserDetailSer, UserDetailSer>();
builder.Services.AddScoped<ICommuneSer, CommuneSer>();
builder.Services.AddScoped<IProvinceSer, ProvinceSer>();
builder.Services.AddScoped<IDistrictSer, DistrictSer>();
builder.Services.AddScoped<IResortSer, ResortSer>();
builder.Services.AddScoped<IResortDetailSer, ResortDetailSer>();
builder.Services.AddScoped<IResortDetailServicesSer, ResortDetailServiceSer>();
builder.Services.AddScoped<IRateSer, RateSer>();
builder.Services.AddScoped<IRoleSer, RoleSer>();
builder.Services.AddScoped<IConvenientSer, ConvenientSer>();
builder.Services.AddScoped<IServiceSer, ServiceSer>();
builder.Services.AddScoped<ITypeRoomSer, TypeRoomSer>();
builder.Services.AddScoped<ITypeRoomResortDetailSer, TypeRoomResortDetailSer>();
builder.Services.AddScoped<IConvenientResortSer, ConvenientResortSer>();

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
