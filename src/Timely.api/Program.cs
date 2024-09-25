using Microsoft.EntityFrameworkCore;
using Timely.api.Context;


var builder = WebApplication.CreateBuilder(args);


// Add services to the container.
builder.Services.AddControllers();


//db
builder.Services.AddDbContext<BancoDedadosContext>(opt =>
    opt.UseInMemoryDatabase("appDB"));


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
