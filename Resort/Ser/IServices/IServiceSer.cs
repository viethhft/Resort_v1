using Resort.Models;

namespace Resort.Ser.IServices
{
	public interface IServiceSer
	{
        public Task<List<Service>> GetAllServices();
        public Task<Service> GetServicesById(int id);
        public Task<bool> AddService(Service service);
        public Task<bool> UpdateService(Service service);
        public Task<bool> RemoveService(Service service);
    }
}
