using Microsoft.AspNetCore.Mvc.Testing;
using Repro;

namespace Tests
{
    public class Tests
    {
        [Test]
        public async Task ShowMemoryLeak()
        {
            for (int i = 0; i < 100000; i++)
            {
                using var host = new Host();

                var client = host.CreateClient();
                var response = await client.GetAsync("/");
                response.EnsureSuccessStatusCode();
            }
        }

        public class Host : WebApplicationFactory<Program>
        {

        }
    }
}
