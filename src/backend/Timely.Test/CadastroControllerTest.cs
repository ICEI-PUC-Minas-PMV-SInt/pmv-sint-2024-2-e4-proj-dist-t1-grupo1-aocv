using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;

using Timely.Controllers;
using Timely.Models;
using Timely.Respositories;


namespace Timely.Test
{
    [TestFixture]
    public class CadastroControllerTest
    {
        private ICadastroRepository _cadastro;
        private CadastroController _controller;
        
        [SetUp]
        public void Setup()
        {
            _cadastro = new CadastroInMemory();
            _controller = new CadastroController(_cadastro);
        }

        [Test]
        public void Create_New_User()
        {

            User? user = new User()
            {
                Email = "ugo@gmail.com",
                Password = "zxcvbnm",
                Nome = "Ugo"
            };

            var result = _controller.Create(user) as CreatedAtActionResult; 
            var actual = result.Value as User;


            Assert.That(actual.UserId, Is.EqualTo(3));
            Assert.That(actual.Password, Is.EqualTo("zxcvbnm"));
            Assert.That(actual.Email, Is.EqualTo("ugo@gmail.com"));
            Assert.That(actual.Nome, Is.EqualTo("Ugo"));
        }
    }
}