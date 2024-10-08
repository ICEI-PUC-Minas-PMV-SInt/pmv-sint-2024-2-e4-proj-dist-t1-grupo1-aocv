using Microsoft.EntityFrameworkCore;
using Timely.Controllers;
using Timely.Repositories;
using Timely.Respositories;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();




builder.Services.AddScoped<ICadastroRepository, CadastroInMemory>();
builder.Services.AddScoped<InterfaceAgendaRepository, AgendaInMemory>();
builder.Services.AddScoped<IViagemEventosRepository, ViagemEventosInMemory>();

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
