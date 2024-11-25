using Timely.Context;
using Timely.Controllers;
using Timely.Repositories;
using Timely.Respositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

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

builder.Services.AddCors(options =>
{
    options.AddPolicy("CorsPolicy", policy =>
    {
        policy.WithOrigins("https://timely.com.br") // URL do seu frontend React
              .AllowAnyMethod() // Permite GET, POST, PUT, DELETE, etc.
              .AllowAnyHeader(); // Permite todos os cabeçalhos
    });
});

// Configuração de autenticação JWT
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,
            ValidIssuer = "timelyApp",
            ValidAudience = "TimelyAppApi",
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("05c45d6538115fbb93c310808056e48e159e67046783eea1facc559e54f0b12243da0831bfc9f5f2bf738378d9e10c47a1450c7b536a9a7982e052d953af31d0b669d430edddfd7dc41a5a39880f9e27c80b301bb565b7207d2c02d4cf1261899e13cc7d3fb576713bbe98a5cfb57bc780a991b390ed47abae9f155c4a84842c1f46538b92575e237420961bc34f355f7a7b4a9f909b0a988d5e932d9a447a88e6718a7fa47647189320180e341794340bc2a24b5a1986b8d1fbc71bbd441c2a01f88b4c7941fae21bb7f42c0ae58a5f932377d0f2162503638bf19c0912618360aa9f5acf1d245124122d75e34745525b87c2fc46381c4319dcf188b26845768e29a5f5c60cd05cbeaeff417a6350733a1a041ff54a5d6d6e64af11b9b759288c41ad863890065b984a94e0305fbdbe927ea30688581c7d5f2732df0adee2733a893830b398dc4901542f2e53775ce547c06af7a99ad6af971f5f75b6074090445a6a3b694c7fb4fa5ef2842e25ccf4d1ea998622de171150c75f579db68ec81cd6155782edabb0543b611e559a344c29b30576c58c2069dff93e1d489be8f5ea43acc37404176f132bd241189efaece43763dbe77132d7d6e6529bcb5f56ac94b2e851b8b9fd0773747fec2bfe4af88d1b0209dc25f19e9cc687fd3fb9e0001a0d470e702b3076abf92366b6d87e61f50c4e758d8f1aedaa3526d103744d9e"))
        };
    }
);


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

app.UseCors("CorsPolicy");

app.UseAuthentication(); 

app.UseAuthorization();

app.MapControllers();

app.Run();