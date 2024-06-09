using FootballDB;
using Microsoft.EntityFrameworkCore;

namespace Football.Services
{
    public class PlayerCollectionService: IPlayerCollectionService
    {
        private readonly DbSet<Player> _players;

        public PlayerCollectionService()
        {
            var context = new FootballContext();
            _players = context.Players;
        }

        public async Task<List<Player>> GetAll()
        {
            var result = await _players.ToListAsync();

            return result;
        }
        public async Task<Player> Get(int id)
        {
            var result = await _players.FirstAsync
                (p => p.Id == id);
            return result;
        }
    }
}
