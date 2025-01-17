using Microsoft.EntityFrameworkCore;
using NBA_API.DAL;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var ConStr = builder.Configuration.GetConnectionString("ConStr");
builder.Services.AddDbContext<Context>(options => options.UseSqlServer(ConStr));

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
