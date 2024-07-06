
namespace SuperHero.Services.HeroService;

public class HeroService : IHeroService
{
    private readonly DataContext _context;

    public HeroService(DataContext context)
    {
        _context = context;
    }
    public async Task<ServiceResponse<List<Hero>>> GetHeroes()
    {
        var response = new ServiceResponse<List<Hero>>
        {
            Data = await _context.Heroes.ToListAsync()
        };

        return response;
    }

    public async Task<ServiceResponse<Hero>> GetHero(int id)
    {
        var response = new ServiceResponse<Hero>();
        var hero = await _context.Heroes.FindAsync(id);

        if (hero == null)
        {
            response.Success = false;
            response.Message = "Not found";
        }

        response.Data = hero;

        return response;
    }
    public async Task<ServiceResponse<List<Hero>>> CreateHero(Hero hero)
    {
        var response = new ServiceResponse<List<Hero>>();

        _context.Heroes.Add(hero);
        await _context.SaveChangesAsync();
        response.Data = await _context.Heroes.ToListAsync();

        return response;
    }

    public async Task<ServiceResponse<Hero>> UpdateHero(int id, Hero UpdatedHero)
    {
        var response = new ServiceResponse<Hero>();
        var hero = await _context.Heroes.FindAsync(id);

        if (hero == null)
        {
            response.Success = false;
            response.Message = "not found";
        }

        hero.Name = UpdatedHero.Name;
        hero.SuperPower = UpdatedHero.SuperPower;

        await _context.SaveChangesAsync();
        response.Data = hero;

        return response;
    }

    public async Task<ServiceResponse<List<Hero>>> DeleteHero(int id)
    {
        var response = new ServiceResponse<List<Hero>>();
        var hero = await _context.Heroes.FindAsync(id);

        if (hero == null)
        {
            response.Success = false;
            response.Message = "not found";
        }

        _context.Heroes.Remove(hero);
        await _context.SaveChangesAsync();
        response.Data = await _context.Heroes.ToListAsync();

        return response;
    }

}
