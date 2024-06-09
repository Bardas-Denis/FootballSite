using FootballDB;
using Microsoft.EntityFrameworkCore;

namespace Football.Services
{
    public class UserCollectionService: IUserCollectionService
    {
        private readonly DbSet<User> _users;

        public UserCollectionService()
        {
            var context = new FootballContext();
            _users = context.Users;
        }

        public async Task<List<User>> GetAll()
        {
            var result = await _users.ToListAsync();

            return result;
        }
        public async Task<User> Get(int id)
        {
            var result = await _users.FirstAsync
                (p => p.Id == id.ToString());
            return result;
        }
        public async Task<bool> Add(User user)
        {
            var context = new FootballContext();
            await context.Users.AddAsync(user);
            context.SaveChanges();
            return true;
        }
       
    }
}
