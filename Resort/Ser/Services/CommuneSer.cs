using Resort.Models;
using Resort.Repo.IReponsitories;
using Resort.Ser.IServices;

namespace Resort.Ser.Services
{
    public class CommuneSer : ICommuneSer
    {
        private readonly ICommuneRepo _communeRepo;
        public CommuneSer(ICommuneRepo communeRepo)
        {
            _communeRepo= communeRepo;
        }
        public Task<List<Commune>> GetAllCommune()
        {
            return _communeRepo.GetAllCommune();
        }

        public Task<Commune> GetCommuneByID(int id)
        {
            return _communeRepo.GetCommuneByID(id);
        }
    }
}
