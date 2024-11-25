using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Timely.Models;
using Timely.Repositories;

namespace Timely.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        private readonly IConfiguration _configuration;

        public LoginController(IUserRepository userRepository, IConfiguration configuration)
        {
            _userRepository = userRepository;
            _configuration = configuration;
        }

        [HttpPost]
        public IActionResult Login([FromBody] LoginRequest login)
        {
            // Buscar o usuário pelo email
            var user = _userRepository.FindByEmail(login.Email);

            // Validar credenciais
            if (user == null || user.Password != login.Password)
            {
                return Unauthorized(new { message = "Credenciais inválidas" });
            }

            // Gerar o token JWT
            var token = GenerateJwtToken(user);

            // Retornar sucesso com token e informações básicas do usuário
            return Ok(new
            {
                message = "Login bem-sucedido",
                token,
                userId = user.UserId,
                nome = user.Nome
            });
        }

        private static string GenerateJwtToken(User user)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("05c45d6538115fbb93c310808056e48e159e67046783eea1facc559e54f0b12243da0831bfc9f5f2bf738378d9e10c47a1450c7b536a9a7982e052d953af31d0b669d430edddfd7dc41a5a39880f9e27c80b301bb565b7207d2c02d4cf1261899e13cc7d3fb576713bbe98a5cfb57bc780a991b390ed47abae9f155c4a84842c1f46538b92575e237420961bc34f355f7a7b4a9f909b0a988d5e932d9a447a88e6718a7fa47647189320180e341794340bc2a24b5a1986b8d1fbc71bbd441c2a01f88b4c7941fae21bb7f42c0ae58a5f932377d0f2162503638bf19c0912618360aa9f5acf1d245124122d75e34745525b87c2fc46381c4319dcf188b26845768e29a5f5c60cd05cbeaeff417a6350733a1a041ff54a5d6d6e64af11b9b759288c41ad863890065b984a94e0305fbdbe927ea30688581c7d5f2732df0adee2733a893830b398dc4901542f2e53775ce547c06af7a99ad6af971f5f75b6074090445a6a3b694c7fb4fa5ef2842e25ccf4d1ea998622de171150c75f579db68ec81cd6155782edabb0543b611e559a344c29b30576c58c2069dff93e1d489be8f5ea43acc37404176f132bd241189efaece43763dbe77132d7d6e6529bcb5f56ac94b2e851b8b9fd0773747fec2bfe4af88d1b0209dc25f19e9cc687fd3fb9e0001a0d470e702b3076abf92366b6d87e61f50c4e758d8f1aedaa3526d103744d9e"));

            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, user.UserId.ToString()),
                new Claim(JwtRegisteredClaimNames.Email, user.Email),
                new Claim(ClaimTypes.Name, user.Nome)
            };

            var token = new JwtSecurityToken(
                issuer: "timelyApp",
                audience: "TimelyAppApi",
                claims: claims,
                expires: DateTime.UtcNow.AddHours(1), // Token expira em 1 hora
                signingCredentials: credentials
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}