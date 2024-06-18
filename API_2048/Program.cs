using API_2048.Contexts;
using dotenv.net;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

// Register DbContext with MySQL
string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
string projectRootDirectory = Path.GetFullPath(Path.Combine(baseDirectory, @"..\.."));

DotEnv.Fluent()
    .WithExceptions()
    .WithEnvFiles(Path.Combine(projectRootDirectory, ".env"))
    .Load();

string connectionString = DotEnv.Fluent()
    .WithEnvFiles(Path.Combine(projectRootDirectory, ".env"))
    .Read()["2048_CON_SECRET_VULPESDEV"];

builder.Services.AddDbContext<HighscoreDataContext>(options =>
    options.UseMySql(connectionString, new MySqlServerVersion(new Version(8, 0, 28))));

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