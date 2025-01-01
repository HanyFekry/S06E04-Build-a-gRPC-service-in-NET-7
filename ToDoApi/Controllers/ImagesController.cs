using Microsoft.AspNetCore.Mvc;
using ToDoGrpc;

namespace ToDoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImagesController(Image.ImageClient imageClient) : ControllerBase
    {
        [HttpGet("{name}")]
        public async Task<ActionResult> GetImageUrl(string name)
        {
            var response = await imageClient.GetUrlAsync(new GetUrlRequest { Name = name });
            return Ok(response.Url);
        }
    }
}
