using FootballDB;

namespace Football.Services
{
    public interface IUserCollectionService: ICollectionService<User>
    {
        public Task<bool> Add(User user);
    }
}
