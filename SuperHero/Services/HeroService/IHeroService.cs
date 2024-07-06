namespace SuperHero.Services.HeroService;

public interface IHeroService
{
    Task<ServiceResponse<List<Hero>>> GetHeroes();
    Task<ServiceResponse<Hero>> GetHero(int id);
    Task<ServiceResponse<List<Hero>>> CreateHero(Hero hero);
    Task<ServiceResponse<Hero>> UpdateHero(int id, Hero UpdatedHero);
    Task<ServiceResponse<List<Hero>>> DeleteHero(int id);
}
