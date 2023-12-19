using Resort.Context;
using Resort.Models;
using Resort.Repo.IReponsitories;

namespace Resort.Repo.Reponsitories
{
	public class ResortRepo : IResortRepo
	{
		private readonly IResortRepo _resortRepo;
		private readonly MyContext _myContext;
		public ResortRepo(IResortRepo resortRepo, MyContext myContext)
		{
			_resortRepo = resortRepo;
			_myContext = myContext;
		}

		public Task<bool> AddResort(Models.Resort resort)
		{
			throw new NotImplementedException();
		}

		public Task<List<Models.Resort>> GetAllResort()
		{
			throw new NotImplementedException();
		}

		public Task<bool> UpdateResort(Models.Resort resort)
		{
			throw new NotImplementedException();
		}
	}
}
