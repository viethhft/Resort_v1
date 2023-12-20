using Resort.Models;
using Resort.Repo.IReponsitories;
using Resort.Ser.IServices;

namespace Resort.Ser.Services
{
    public class ServiceSer : IServiceSer
    {
        private readonly IServiceRepo _serviceRepo;
        public ServiceSer(IServiceRepo serviceRepo)
        {
            _serviceRepo = serviceRepo;
        }
        public Task<bool> AddService(Service service)
        {
            return _serviceRepo.AddService(service);
        }

        public Task<List<Service>> GetAllServices()
        {
            return _serviceRepo.GetAllServices();
        }

        public Task<Service> GetServicesById(int id)
        {
            return _serviceRepo.GetServicesById(id);
        }

        public Task<bool> RemoveService(Service service)
        {
            return _serviceRepo.RemoveService(service);
        }

        public Task<bool> UpdateService(Service service)
        {
            return _serviceRepo.UpdateService(service);
        }
    }
}
