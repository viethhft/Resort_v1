using Resort.Context;
using Resort.Models;
using Resort.Repo.IReponsitories;

namespace Resort.Repo.Reponsitories
{
	public class ServiceRepo : IServiceRepo
	{
		private readonly IServiceRepo _serviceRepo;
		private readonly MyContext _myContext;
		public ServiceRepo(IServiceRepo serviceRepo, MyContext myContext)
		{
			_serviceRepo = serviceRepo;
			_myContext = myContext;
		}

		public Task<bool> AddService(Service service)
		{
			throw new NotImplementedException();
		}

		public Task<List<Service>> GetAllServices()
		{
			throw new NotImplementedException();
		}

		public Task<Service> GetServicesById(int id)
		{
			throw new NotImplementedException();
		}

		public Task<bool> RemoveService(Service service)
		{
			throw new NotImplementedException();
		}

		public Task<bool> UpdateService(Service service)
		{
			throw new NotImplementedException();
		}
	}
}
