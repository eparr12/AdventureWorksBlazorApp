using AdventureWorksBlazorClassLibrary.Data;
using AdventureWorksBlazorClassLibrary.DataAccess;
using AdventureWorksBlazorUI.Data;
using AutoMapper;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddAutoMapper(typeof(Program));
builder.Services.AddTransient<ISqlDataAccess, SqlDataAccess>();
builder.Services.AddTransient<IDropDownData, DropDownData>();
builder.Services.AddTransient<INonSalesEmployeeData, NonSalesEmployeeData>();
builder.Services.AddTransient<IMapper, Mapper>();
builder.Services.AddTransient<WireUpLists, WireUpLists>();

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
