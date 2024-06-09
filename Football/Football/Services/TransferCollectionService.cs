using FootballDB;
using Microsoft.EntityFrameworkCore;

namespace Football.Services
{
    public class TransferCollectionService: ITransferCollectionService
    {
        private readonly DbSet<Transfer> _transfers;

        public TransferCollectionService()
        {
            var context = new FootballContext();
            _transfers = context.Transfers;
        }

        public async Task<List<Transfer>> GetAll()
        {
            var result = await _transfers.ToListAsync();

            return result;
        }
        public async Task<Transfer> Get(int id)
        {
            var result = await _transfers.FirstAsync
                (p => p.Id == id);
            return result;
        }
    }
}
