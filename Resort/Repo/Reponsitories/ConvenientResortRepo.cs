using Resort.Context;
using Resort.Models;
using Resort.Repo.IReponsitories;

namespace Resort.Repo.Reponsitories
{
	public class ConvenientResortRepo : IConvenientResortRepo
	{
		private readonly IConvenientResortRepo _convenientResortRepo;
		private readonly MyContext _myContext;
		public ConvenientResortRepo(IConvenientResortRepo convenientResortRepo, MyContext myContext)
		{
			_convenientResortRepo = convenientResortRepo;
			_myContext = myContext;
		}

		public Task<bool> Add(ConvenientResort convenientResort)
		{
			throw new NotImplementedException();
		}

		public Task<List<ConvenientResort>> GetConvenientByIdResort(int id)
		{
			throw new NotImplementedException();
		}

		public Task<bool> Remove(ConvenientResort convenientResort)
		{
			throw new NotImplementedException();
		}

		public Task<bool> Update(ConvenientResort convenientResort)
		{
			throw new NotImplementedException();
		}
	}
}
