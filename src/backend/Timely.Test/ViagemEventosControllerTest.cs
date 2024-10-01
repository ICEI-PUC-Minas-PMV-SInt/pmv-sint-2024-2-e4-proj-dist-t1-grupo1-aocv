using NUnit.Framework;
using Timely.Controllers;
using Timely.Models;
using Timely.Repositories; // Ajuste para o namespace correto do repositório
using Microsoft.AspNetCore.Mvc;

namespace Timely.Test
{
    [TestFixture]
    public class ViagemEventosControllerTest
    {
        private IViagemEventosRepository _viagemEventosRepository;
        private ViagemEventosController _viagemEventosController;

        [SetUp]
        public void SetUp()
        {
            _viagemEventosRepository = new ViagemEventosInMemory(); // Supondo que você tenha uma implementação em memória
            _viagemEventosController = new ViagemEventosController(_viagemEventosRepository);
        }

        [Test]
        public void Create_New_ViagemEvento()
        {
            // Arrange: configurar os dados do novo evento
            var novoEvento = new ViagemEventos
            {
                ViagemEventosId = 1,
                Nome = "Chegada em Minas",
                Descricao = "Evento de chegada",
                Horario = DateTime.Now,
                ViagemId = 1
            };

            // Act: chamar o método de criação
            var result = _viagemEventosController.Criar_ViagemEvento(novoEvento) as CreatedAtActionResult;
            var actual = result.Value as ViagemEventos;

            // Assert: verificar se o evento foi criado corretamente
            Assert.That(result, Is.InstanceOf<CreatedAtActionResult>());
            Assert.That(actual.Nome, Is.EqualTo("Chegada em Minas"));
            Assert.That(actual.Descricao, Is.EqualTo("Evento de chegada"));
        }

        [Test]
        public void Get_ViagemEvento_Returns_NotFound_When_EventDoesNotExist()
        {
            // Act: tentar obter um evento que não existe
            var result = _viagemEventosController.Get(999); // ID que não existe

            // Assert: verificar se retorna NotFound
            Assert.That(result.Result, Is.InstanceOf<NotFoundResult>());
        }

        [Test]
        public void Get_ViagemEvento_Returns_Event_When_Exists()
        {
            // Arrange: criar e adicionar um evento
            var eventoExistente = new ViagemEventos
            {
                ViagemEventosId = 3,
                Nome = "Evento Existente",
                Descricao = "Descrição do Evento",
                Horario = DateTime.Now,
                ViagemId = 1
            };
            _viagemEventosRepository.Add(eventoExistente); // Supondo que tenha um método Add no repositório

            // Act: tentar obter o evento existente
            var result = _viagemEventosController.Get(3); // ID que existe

            // Assert: verificar se retorna o evento
            var okResult = result.Result as OkObjectResult;
            var actual = okResult.Value as ViagemEventos;
            Assert.That(actual.Nome, Is.EqualTo("Evento Existente"));
        }

        [Test]
        public void Update_ViagemEvento_Returns_NoContent_When_Updated()
        {
            // Arrange: criar um evento existente
            var eventoExistente = new ViagemEventos
            {
                ViagemEventosId = 1,
                Nome = "Evento Para Atualizar",
                Descricao = "Descrição do Evento",
                Horario = DateTime.Now,
                ViagemId = 1
            };
            _viagemEventosRepository.Add(eventoExistente);

            // Atualizar o evento
            var eventoAtualizado = new ViagemEventos
            {
                ViagemEventosId = 1,
                Nome = "Evento Atualizado",
                Descricao = "Descrição Atualizada",
                Horario = DateTime.Now,
                ViagemId = 1
            };

            // Act: chamar o método de atualização
            var result = _viagemEventosController.Update(1, eventoAtualizado);

            // Assert: verificar se o retorno é NoContent
            Assert.That(result, Is.InstanceOf<NoContentResult>());
        }
    }
}
