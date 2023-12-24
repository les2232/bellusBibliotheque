using bellusBibliotheca2.Models.DataLayer;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


builder.Services.AddRouting(options => { options.LowercaseUrls = true; options.AppendTrailingSlash = true; });

builder.Services.AddMemoryCache();
builder.Services.AddSession();

builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<BellusContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("BellusContext")));

var app = builder.Build();

//builder.Services.AddTransient(typeof(IRepository<>), typeof(Repository<>));
//builder.Services.AddHttpContextAccessor();

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

app.UseSession();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
