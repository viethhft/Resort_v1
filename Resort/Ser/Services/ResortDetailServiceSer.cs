using Resort.Models;
using Resort.Repo.IReponsitories;
using Resort.Ser.IServices;

namespace Resort.Ser.Services
{
    public class ResortDetailServiceSer : IResortDetailServicesSer
    {
        private readonly IResortDetailServicesRepo _resortDetailServicesRepo;
        public ResortDetailServiceSer(IResortDetailServicesRepo resortDetailServicesRepo)
        {
            _resortDetailServicesRepo = resortDetailServicesRepo;
        }
        public Task<bool> Add(ResortDetailServices service)
        {
            return _resortDetailServicesRepo.Add(service);
        }

        public Task<List<ResortDetailServices>> GetListByIdResort(int id)
        {
            return _resortDetailServicesRepo.GetListByIdResort(id);
        }

        public Task<bool> Remove(ResortDetailServices services)
        {
            return _resortDetailServicesRepo.Remove(services);
        }

        public Task<bool> Update(ResortDetailServices services)
        {
            return _resortDetailServicesRepo.Update(services);
        }
    }
}
