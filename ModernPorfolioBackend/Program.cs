using Microsoft.EntityFrameworkCore;
using ModernPorfolioBackend.Data;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddEndpointsApiExplorer();

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite("Data Source=app.db"));

var app = builder.Build();


app.UseHttpsRedirection();



app.Run();

