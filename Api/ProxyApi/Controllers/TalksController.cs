// ---------------------------------------------------------------
// Copyright (c) Mabrouk Mahdhi. 
//  W/ love for all .NET developers from around the world.
// ---------------------------------------------------------------

using Microsoft.AspNetCore.Mvc;

namespace ProxyApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TalksController(HttpClient httpClient) : ControllerBase
    {
        private readonly HttpClient httpClient = httpClient;

        [HttpGet]
        public async Task<IActionResult> GetVideos()
        {
            var response = await httpClient.GetAsync("https://dotnet.microsoft.com/api/videos/on-dotnet-live");
            var content = await response.Content.ReadAsStringAsync();
            return Content(content, response.Content.Headers.ContentType.ToString());
        }
    }

}
