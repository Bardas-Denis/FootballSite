using FootballDB;
using Microsoft.EntityFrameworkCore;

namespace Football.Services
{
    public class LeagueCollectionService: ILeagueCollectionService
    {
        private readonly DbSet<League> _leagues;

        public LeagueCollectionService() 
        {
            var context = new FootballContext();
            _leagues = context.Leagues;
        }

        public async Task<List<League>> GetAll()
        {
            var result = await _leagues.ToListAsync();

            return result;
        }
        public async Task<League> Get(int id)
        {
            var result = await _leagues.FirstAsync
                (p => p.Id == id);
            return result;
        }
    }
}
