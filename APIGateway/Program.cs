using Ocelot.DependencyInjection;
using Ocelot.Middleware;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();


//adding json api gateway file:
builder.Configuration.AddJsonFile("ocelot.json");


//adding ocelot:
builder.Services.AddOcelot();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}


//adding the ocelot configuration for API gateway:
//app.ConfigureAppConfiguration((ctx, config) => { config.AddJsonFile("ocelot.json"); });
app.UseOcelot().Wait();

app.UseHttpsRedirection();
 
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
