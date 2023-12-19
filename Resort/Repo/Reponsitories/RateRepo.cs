using Resort.Context;
using Resort.Models;
using Resort.Repo.IReponsitories;

namespace Resort.Repo.Reponsitories
{
	public class RateRepo : IRateRepo
	{
		private readonly IRateRepo _rateRepo;
		private readonly MyContext _myContext;
		public RateRepo(IRateRepo rateRepo, MyContext myContext)
		{
			_rateRepo = rateRepo;
			_myContext = myContext;
		}

		public Task<bool> AddRate(Rate rate)
		{
			throw new NotImplementedException();
		}

		public Task<List<Rate>> GetListRateByIdResort()
		{
			throw new NotImplementedException();
		}

		public Task<bool> RemoveRate(Rate rate)
		{
			throw new NotImplementedException();
		}

		public Task<bool> UpdateRate(Rate rate)
		{
			throw new NotImplementedException();
		}
	}
}
