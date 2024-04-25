using Microsoft.EntityFrameworkCore;
using Student.API;
using Student.API.Migrations;
using Student.API.Services;
using System.Security.Cryptography;
using static System.Runtime.InteropServices.JavaScript.JSType;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Connection string
var connString = "Data Source=DESKTOP-1USP24N; Initial Catalog = StocksDatabase; Integrated Security = True; Pooling = False; Encrypt = False; Trust Server Certificate=True";

builder.Services
    .AddDbContext<AppDbContext>(o => o.UseSqlServer(connString));

builder.Services.AddScoped<IStocksService, StocksService>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
