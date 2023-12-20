using Resort.Models;
using Resort.Repo.IReponsitories;
using Resort.Ser.IServices;

namespace Resort.Ser.Services
{
    public class ConvenientResortSer : IConvenientResortSer
    {
        private readonly IConvenientResortRepo _convenientResortRepo;
        public ConvenientResortSer(IConvenientResortRepo convenientResortRepo)
        {
            _convenientResortRepo= convenientResortRepo;
        }
        public Task<bool> Add(ConvenientResort convenientResort)
        {
            return _convenientResortRepo.Add(convenientResort);
        }

        public Task<List<ConvenientResort>> GetConvenientByIdResort(int id)
        {
            return _convenientResortRepo.GetConvenientByIdResort(id);
        }

        public Task<bool> Remove(ConvenientResort convenientResort)
        {
            return _convenientResortRepo.Remove(convenientResort);
        }

        public Task<bool> Update(ConvenientResort convenientResort)
        {
            return _convenientResortRepo.Update(convenientResort);
        }
    }
}
