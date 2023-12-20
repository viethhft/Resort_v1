using Resort.Models;
using Resort.Repo.IReponsitories;
using Resort.Ser.IServices;

namespace Resort.Ser.Services
{
    public class ProvinceSer : IProvinceSer
    {
        private readonly IProvinceRepo _provinceRepo;
        public ProvinceSer(IProvinceRepo provinceRepo)
        {
            _provinceRepo = provinceRepo;
        }
        public Task<List<Province>> GetAllProvince()
        {
            return _provinceRepo.GetAllProvince();
        }

        public Task<Province> GetProvinceByID(int id)
        {
            return _provinceRepo.GetProvinceByID(id);
        }
    }
}
