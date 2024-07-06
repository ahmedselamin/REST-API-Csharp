
namespace SuperHero.Services.HeroService
{
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
        public Task<ServiceResponse<Hero>> CreateHero(Hero hero)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<bool>> DeleteHero(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<Hero>> GetHero(int id)
        {
            throw new NotImplementedException();
        }



        public Task<ServiceResponse<Hero>> UpdateHero(Hero hero)
        {
            throw new NotImplementedException();
        }
    }
}
