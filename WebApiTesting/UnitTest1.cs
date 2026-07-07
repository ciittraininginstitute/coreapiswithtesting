using Microsoft.AspNetCore.Mvc.Testing;
using System.Net;

namespace WebApiTesting
{
    public class UnitTest1
    {
        [Fact]
        public async Task GetAllApiTest()
        {
            var factory = new WebApplicationFactory<Program>();
            var client = factory.CreateClient();
            var response = await client.GetAsync("api/student");
            //Assert.Equal(HttpStatusCode.OK, response.StatusCode);
            Assert.Equal(200, (int)response.StatusCode);


        }
        //[Fact]
        //public async Task GetByIdApiTest ()
        //{
        //    var factory = new WebApplicationFactory<Program>();
        //    var client = factory.CreateClient();
        //    var response = await client.GetAsync("api/student/29");
        //    //Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        //    Assert.Equal(200, (int)response.StatusCode);


        //}
        [Theory]
        [InlineData(1,200)]
        [InlineData(11,204)]
        [InlineData(4,200)]
        [InlineData(7,200)]
        [InlineData(19,200)]
        public async Task GetByIdApiTest(int id, int expected)
        {
            var factory = new WebApplicationFactory<Program>();
            var client = factory.CreateClient();
            var response = await client.GetAsync($"api/student/{id}");
            //Assert.Equal(HttpStatusCode.OK, response.StatusCode);
            Assert.Equal(expected, (int)response.StatusCode);
        }
    }
}
