using FootballDB;
using Microsoft.EntityFrameworkCore;

namespace Football.Services
{
    public class TeamCollectionService: ITeamCollectionService
    {
        private readonly DbSet<Team> _teams;

        public TeamCollectionService()
        {
            var context = new FootballContext();
            _teams = context.Teams;
        }

        public async Task<List<Team>> GetAll()
        {
            var result = await _teams.ToListAsync();

            return result;
        }
        public async Task<Team> Get(int id)
        {
            var result = await _teams.FirstAsync
                (p => p.Id == id);
            return result;
        }
    }
}
