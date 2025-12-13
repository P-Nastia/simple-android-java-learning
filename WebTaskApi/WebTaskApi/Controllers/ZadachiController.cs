using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebTaskApi.Interfaces;
using WebTaskApi.Models.Zadacha;

namespace WebTaskApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ZadachiController(IZadachiService zadachiService) : ControllerBase
{

    [HttpGet()]
    public async Task<IActionResult> Get()
    {
        var items = await zadachiService.GetAllAsync();

        return Ok(items);
    }

    [HttpPost()]
    public async Task<IActionResult> Post([FromForm] ZadachaCreateModel model)
    {
        var res = await zadachiService.CreateZadachyAsync(model);
        return Ok(res);
    }
}
