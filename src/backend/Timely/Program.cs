using Timely.Context;
using Timely.Controllers;
using Timely.Repositories;
using Timely.Respositories;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

string mySqlConnection =
              builder.Configuration.GetConnectionString("TimelyAppMysql");
           
//                          O contexto de dados
builder.Services.AddDbContextPool<BancoDeDadosContext>(options => 
                options.UseMySql( 
                    mySqlConnection, 
                    new MySqlServerVersion(new Version())));

//dbSqlite
// builder.Services.AddDbContext<BancoDeDadosContext>(opt =>
//     opt.UseSqlite("Data Source=app.db"));


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();




builder.Services.AddScoped<ICadastroRepository, CadastroInMemory>();
builder.Services.AddScoped<InterfaceAgendaRepository, AgendaInMemory>();
builder.Services.AddScoped<IViagemEventosRepository, ViagemEventosInMemory>();
builder.Services.AddScoped<IUserRepository, UserInMemory>();
builder.Services.AddScoped<ITarefaRepository, TarefaInMemory>();

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
