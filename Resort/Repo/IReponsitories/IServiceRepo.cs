using Resort.Models;

namespace Resort.Repo.IReponsitories
{
	public interface IServiceRepo
	{
		public Task<List<Service>> GetAllServices();
		public Task<Service> GetServicesById(int id);
		public Task<bool> AddService(Service service);
		public Task<bool> UpdateService(Service service);
		public Task<bool> RemoveService(Service service);
	}
}
