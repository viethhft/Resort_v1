using Resort.Context;
using Resort.Models;
using Resort.Repo.IReponsitories;

namespace Resort.Repo.Reponsitories
{
	public class ConvenientRepo : IConvenientRepo
	{
		private readonly IConvenientRepo _convenientRepo;
		private readonly MyContext _myContext;
		public ConvenientRepo(IConvenientRepo convenientRepo, MyContext myContext)
		{
			_convenientRepo = convenientRepo;
			_myContext = myContext;
		}

		public Task<bool> AddConvenient(Convenient convenient)
		{
			throw new NotImplementedException();
		}

		public Task<List<Convenient>> GetAllConvenient()
		{
			throw new NotImplementedException();
		}

		public Task<Convenient> GetConvenient(int id)
		{
			throw new NotImplementedException();
		}

		public Task<bool> UpdateConvenient(Convenient convenient)
		{
			throw new NotImplementedException();
		}
	}
}
