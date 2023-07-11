using PatientPortal_WebApp.Utilities;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddHttpClient();
var appSettingsType = typeof(AppSettings);
var baseUrlProperty = appSettingsType.GetProperty("BaseUrl", BindingFlags.Public | BindingFlags.Static | BindingFlags.SetProperty);
baseUrlProperty.SetValue(null, builder.Configuration.GetSection("Settings:BaseUrl").Value.ToString());
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

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
