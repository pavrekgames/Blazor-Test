using BlazorLearning.Data;
using BlazorLearning.Helpers;
using BlazorLearning.Interfaces;
using BlazorLearning.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddScoped<JsConsole>();

builder.Services.AddScoped<IPetApiService, PetApiService>();
builder.Services.AddScoped<IUserApiService, UserApiService>();

builder.Services.AddScoped(http => new HttpClient
{
    BaseAddress = new Uri("http://localhost:5251/api/")
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
