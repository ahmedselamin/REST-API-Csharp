namespace SuperHero.Services.HeroService;

public interface IHeroService
{
    Task<ServiceResponse<List<Hero>>> GetHeroes();
    Task<ServiceResponse<Hero>> GetHero(int id);
    Task<ServiceResponse<Hero>> CreateHero(Hero hero);
    Task<ServiceResponse<Hero>> UpdateHero(Hero hero);
    Task<ServiceResponse<bool>> DeleteHero(int id);
}
