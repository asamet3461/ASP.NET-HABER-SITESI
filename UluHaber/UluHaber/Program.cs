using Microsoft.EntityFrameworkCore;
using UluHaber.Data;
using UluHaber.Entities;
using UluHaber.Models;
using Microsoft.AspNetCore.Authentication.Cookies;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(x => {
    x.LoginPath = "/Login";
    x.Cookie.Name= "AdminLogin";
});

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
          name: "areas",
          pattern: "{area:exists}/{controller=Main}/{action=Index}/{id?}"
        );
app.MapControllerRoute(
    name: "categoryBySlug",
    pattern: "Categories/Index/{slug?}",
    defaults: new { controller = "Categories", action = "Index" });
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
