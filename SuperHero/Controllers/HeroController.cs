using Microsoft.AspNetCore.Mvc;

namespace SuperHero.Controllers;

[Route("api/[controller]")]
[ApiController]
public class HeroController : ControllerBase
{
    private readonly IHeroService _heroService;

    public HeroController(IHeroService heroService)
    {
        _heroService = heroService;
    }

    [HttpGet]
    public async Task<ActionResult<ServiceResponse<List<Hero>>>> GetHeroes()
    {
        var result = await _heroService.GetHeroes();

        return Ok(result);
    }
}
