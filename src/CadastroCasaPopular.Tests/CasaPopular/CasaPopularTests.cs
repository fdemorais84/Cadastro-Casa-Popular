using CadastroCasaPopular.Api;
using CadastroCasaPopular.Api.ViewModel;
using CasaPopular.Api.Controllers;
using CasaPopular.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System.Threading.Tasks;
using Xunit;

namespace CadastroCasaPopular.Tests.CasaPopular
{
    [Collection(nameof(IntegrationTestsFixtureCollection))]
    public class CasaPopularTests
    {
        public const string urlApi = "api/";

        private readonly IntegrationTestsFixture<StartupTests> _testsFixture;

        private FamiliaViewModel dadosFamilia;

        public CasaPopularTests(IntegrationTestsFixture<StartupTests> testsFixture)
        {
            _testsFixture = testsFixture;

            dadosFamilia = new FamiliaViewModel
            {
                Sobrenome = "Araujo",
                Pai = "Marcio",
                Mae = "Marcia",
                RendaFamiliar = 0,
                Pontuacao = 0
            };
        }

        [Fact]
        public async Task ConsultarFamilias()
        {
            //Arrange
            var casaPopularService = new Mock<ICasaPopularService>().Object;
            var casaPopularController = new CasaPopularController(casaPopularService);

            //Act
            var consultaFamilias = await casaPopularController.ConsultarFamilias();
            var statusCode = (consultaFamilias as OkObjectResult).StatusCode;

            //Assert
            Assert.NotNull(consultaFamilias);
            Assert.Equal(200, statusCode);
        }

        [Fact]
        public async Task CadastrarFamilia()
        {
            //Arrange
            var casaPopularService = new Mock<ICasaPopularService>().Object;
            var casaPopularController = new CasaPopularController(casaPopularService);

            //Act
            var salvarFamilia = await casaPopularController.CadastrarFamilia(dadosFamilia);
            var statusCode = (salvarFamilia as OkObjectResult).StatusCode;

            //Assert
            Assert.Equal(200, statusCode);
        }            
        
    }
}
