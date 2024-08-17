using Microsoft.EntityFrameworkCore;
using WayniApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<UserContext>(opt =>
opt.UseInMemoryDatabase("TodoList"));
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseCors(x => x
                    .AllowAnyMethod()
                    .AllowAnyHeader()
                   .AllowAnyOrigin()
                    );

app.UseHttpsRedirection();

app.UseAuthorization();


app.MapControllers();

app.Run();
