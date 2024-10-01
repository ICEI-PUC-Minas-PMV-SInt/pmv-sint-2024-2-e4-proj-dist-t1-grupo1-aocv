using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;

using Timely.Controllers;
using Timely.Models;
using Timely.Respositories;

namespace Timely.Test
{
    [TestFixture]
    public class AgendaControllerTest
    {

        private InterfaceAgendaRepository _IAgenda;
        private AgendaController _AgendaController;

        [SetUp]
        public void SetUp()
        {
            _IAgenda = new AgendaInMemory();
            _AgendaController = new AgendaController(_IAgenda); // Correção aqui

        }


        [Test]
        public void Create_New_User_Agenda()
        {
            Agenda agenda = new Agenda();
            {
                agenda.AgendaId = 1;
                agenda.Name = "puc minas";
                agenda.Description = "viagem minas";
                agenda.Date = DateTime.Now;
            }


            var result = _AgendaController.Criar_Agenda(agenda) as CreatedAtActionResult;
            var actual = result.Value as Agenda;

            //testa
            Assert.That(actual.Name, Is.EqualTo("puc minas"));
            Assert.That(actual.Description, Is.EqualTo("viagem minas"));
            

            //Assert.That(result, Is.InstanceOf<CreatedAtActionResult>());


        }


    }
}