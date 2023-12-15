using Api.Model;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc.Testing;
using System.Net.Http.Json;

namespace Api.Tests.Integeration.Controllers
{
    public class CustomersControllerTests
    {
        [Fact]
        public async Task Test1()
        {
            var factory = new WebApplicationFactory<Api.Controllers.CustomersController>();
            var httpClient = factory.CreateClient();

            var customer =await httpClient.GetFromJsonAsync<Customer>("customers");

            customer.Should().NotBeNull();
            customer.Id.Should().Be(1);
            customer.Name.Should().Be("Ali");
        }
    }
}
