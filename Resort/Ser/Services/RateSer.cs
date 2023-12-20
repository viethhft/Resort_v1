using Resort.Models;
using Resort.Repo.IReponsitories;
using Resort.Ser.IServices;

namespace Resort.Ser.Services
{
    public class RateSer : IRateSer
    {
        private readonly IRateRepo _rateRepo;
        public RateSer(IRateRepo rateRepo)
        {
            _rateRepo = rateRepo;
        }
        public Task<bool> AddRate(Rate rate)
        {
            return _rateRepo.AddRate(rate);
        }

        public Task<List<Rate>> GetListRateByIdResort(int id)
        {
            return _rateRepo.GetListRateByIdResort(id);
        }

        public Task<bool> RemoveRate(Rate rate)
        {
            return _rateRepo.RemoveRate(rate);
        }

        public Task<bool> UpdateRate(Rate rate)
        {
            return _rateRepo.UpdateRate(rate);
        }
    }
}
