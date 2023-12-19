using Resort.Context;
using Resort.Models;
using Resort.Repo.IReponsitories;

namespace Resort.Repo.Reponsitories
{
	public class ResortDetailRepo : IResortDetailRepo
	{
		private readonly IResortDetailRepo _resortDetailRepo;
		private readonly MyContext _myContext;
		public ResortDetailRepo(IResortDetailRepo resortDetailRepo, MyContext myContext)
		{
			_resortDetailRepo = resortDetailRepo;
			_myContext = myContext;
		}

		public Task<bool> AddResortDetail(ResortDetail resortDetail)
		{
			throw new NotImplementedException();
		}

		public Task<ResortDetail> GetResortDetailByID(int id)
		{
			throw new NotImplementedException();
		}

		public Task<bool> UpdateResortDetail(ResortDetail resortDetail)
		{
			throw new NotImplementedException();
		}
	}
}
