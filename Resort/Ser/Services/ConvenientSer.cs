using Resort.Models;
using Resort.Repo.IReponsitories;
using Resort.Ser.IServices;

namespace Resort.Ser.Services
{
    public class ConvenientSer : IConvenientSer
    {
        private readonly IConvenientRepo _convenientRepo;
        public ConvenientSer(IConvenientRepo convenientRepo)
        {
            _convenientRepo= convenientRepo;
        }
        public Task<bool> AddConvenient(Convenient convenient)
        {
            return _convenientRepo.AddConvenient(convenient);
        }

        public Task<List<Convenient>> GetAllConvenient()
        {
            return _convenientRepo.GetAllConvenient();
        }

        public Task<Convenient> GetConvenient(int id)
        {
            return _convenientRepo.GetConvenient(id);
        }

        public Task<bool> UpdateConvenient(Convenient convenient)
        {
            return _convenientRepo.UpdateConvenient(convenient);
        }
    }
}
