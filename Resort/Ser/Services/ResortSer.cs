using Resort.Repo.IReponsitories;
using Resort.Ser.IServices;

namespace Resort.Ser.Services
{
    public class ResortSer : IResortSer
    {
        private readonly IResortRepo _resortRepo;
        public ResortSer(IResortRepo resortRepo)
        {
            _resortRepo = resortRepo;
        }
        public Task<bool> AddResort(Models.Resort resort)
        {
           return _resortRepo.AddResort(resort);
        }

        public Task<List<Models.Resort>> GetAllResort()
        {
            return _resortRepo.GetAllResort();
        }

        public Task<bool> UpdateResort(Models.Resort resort)
        {
            return _resortRepo.UpdateResort(resort);
        }
    }
}
