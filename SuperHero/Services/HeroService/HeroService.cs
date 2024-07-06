
namespace SuperHero.Services.HeroService
{
    public class HeroService : IHeroService
    {

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

        public Task<ServiceResponse<List<Hero>>> GetHeroes()
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<Hero>> UpdateHero(Hero hero)
        {
            throw new NotImplementedException();
        }
    }
}
