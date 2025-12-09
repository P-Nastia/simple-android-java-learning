using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebTaskApi.Models.Zadacha;

namespace WebTaskApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ZadachiController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetList()
        {
            var items = new List<ZadachaItemModel>
            {
                new ZadachaItemModel{Id = 1, Name = "Mop the floor"},
                new ZadachaItemModel{Id = 2, Name = "Walk the dog"},
                new ZadachaItemModel{Id = 3, Name = "Feed the dog"},
            };
            return Ok(items);
        }
    }
}
