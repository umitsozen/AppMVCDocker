using Microsoft.Extensions.FileProviders;

var builder = WebApplication.CreateBuilder(args);

//get current path and set to fileProvider
IFileProvider fileProvider = new PhysicalFileProvider(Directory.GetCurrentDirectory());

builder.Services.AddSingleton<IFileProvider>(fileProvider);
// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
