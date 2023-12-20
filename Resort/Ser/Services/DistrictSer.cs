using Resort.Models;
using Resort.Repo.IReponsitories;
using Resort.Ser.IServices;

namespace Resort.Ser.Services
{
    public class DistrictSer : IDistrictSer
    {
        private readonly IDistrictRepo _districtRepo;
        public DistrictSer(IDistrictRepo districtRepo)
        {
            _districtRepo = districtRepo;
        }
        public Task<List<District>> GetAllDistrict()
        {
            return _districtRepo.GetAllDistrict();
        }

        public Task<List<District>> GetDistrictByID(int id)
        {
            return _districtRepo.GetDistrictByID(id);
        }
    }
}
