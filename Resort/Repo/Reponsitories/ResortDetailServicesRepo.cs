using Resort.Context;
using Resort.Models;
using Resort.Repo.IReponsitories;

namespace Resort.Repo.Reponsitories
{
	public class ResortDetailServicesRepo : IResortDetailServicesRepo
	{
		private readonly IResortDetailServicesRepo _resortDetailServicesRepo;
		private readonly MyContext _myContext;
		public ResortDetailServicesRepo(IResortDetailServicesRepo resortDetailServicesRepo, MyContext myContext)
		{
			_resortDetailServicesRepo = resortDetailServicesRepo;
			_myContext = myContext;
		}

		public Task<bool> Add(ResortDetailServices service)
		{
			throw new NotImplementedException();
		}

		public Task<List<ResortDetailServices>> GetListByIdResort(int id)
		{
			throw new NotImplementedException();
		}

		public Task<bool> Update(ResortDetailServices services)
		{
			throw new NotImplementedException();
		}
	}
}
