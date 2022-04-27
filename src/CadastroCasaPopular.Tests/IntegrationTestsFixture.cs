using CadastroCasaPopular.Api;
using CadastroCasaPopular.Tests.Config;
using CasaPopular.Api;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using Xunit;

namespace CadastroCasaPopular.Tests
{
    [CollectionDefinition(nameof(IntegrationTestsFixtureCollection))]
    public class IntegrationTestsFixtureCollection : ICollectionFixture<IntegrationTestsFixture<StartupTests>> { }

    public class IntegrationTestsFixture<T> : IDisposable where T : class
    {
        public readonly CasaPopularFactory<T> Factory;
        public HttpClient Client;

        public IntegrationTestsFixture()
        {
            Factory = new CasaPopularFactory<T>();
            Client = Factory.CreateClient();
        }

        public ByteArrayContent ConverterParaByteArrayContent<Tdata>(Tdata data)
        {
            var content = new ByteArrayContent(System.Text.Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(data)));
            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            return content;
        }

        public void Dispose()
        {
            Client.Dispose();
            Factory.Dispose();
        }
    }
}
