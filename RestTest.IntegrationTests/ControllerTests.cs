using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WebApi;
using WebApi.Models;
using Xunit;

namespace RestTest.IntegrationTests
{
    public class ControllerTests : IClassFixture<TestFixture<Startup>>
    {
        private HttpClient Client;

        public ControllerTests(TestFixture<Startup> fixture)
        {
            Client = fixture.Client;
        }

        [Fact]
        public async Task TestGetHi()
        {
            // Arrange
            var request = "/hi/1";

            // Act
            var response = await Client.GetAsync(request);

            // Assert
            response.EnsureSuccessStatusCode();
        }


        [Fact]
        public async Task TestPostStockItemAsync()
        {
            // Arrange
            var request = new HiModel { Id = 3, Name = "Hi no 3" };

            // Act
            var response = await Client.PostAsync("/api/hi", ContentHelper.GetStringContent(request));
            var value = await response.Content.ReadAsStringAsync();

            // Assert
            response.EnsureSuccessStatusCode();
        }

       


    }
}
