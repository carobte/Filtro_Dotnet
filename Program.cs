using DotNetEnv;
using Filtro_Dotnet.Config;
using Filtro_Dotnet.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
Env.Load();

// Database conection

var host = Environment.GetEnvironmentVariable("DB_HOST");
var databaseName = Environment.GetEnvironmentVariable("DB_DATABASE");
var port = Environment.GetEnvironmentVariable("DB_PORT");
var username = Environment.GetEnvironmentVariable("DB_USERNAME");
var password = Environment.GetEnvironmentVariable("DB_PASSWORD");

var connectionString = $"server={host};port={port};database={databaseName};uid={username};password={password}";

// Add services to the container.
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseMySql(connectionString, ServerVersion.Parse("8.0.2-mysql")));

builder.Services.AddSingleton<Utilities>();

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
