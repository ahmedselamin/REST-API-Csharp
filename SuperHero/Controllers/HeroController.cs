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

    [HttpGet("{id}")]
    public async Task<ActionResult<ServiceResponse<Hero>>> GetHero(int id)
    {
        var result = await _heroService.GetHero(id);

        return Ok(result);
    }

    [HttpPost]
    public async Task<ActionResult<ServiceResponse<Hero>>> CreateHero(Hero hero)
    {
        var result = await _heroService.CreateHero(hero);

        return Ok(result);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<ServiceResponse<Hero>>> UpdateHero(int id, Hero newHero)
    {
        var result = await _heroService.UpdateHero(id, newHero);

        return Ok(result);
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<ServiceResponse<List<Hero>>>> DeleteHero(int id)
    {
        var result = await _heroService.DeleteHero(id);

        return Ok(result);
    }
}
