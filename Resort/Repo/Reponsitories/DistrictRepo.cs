using Resort.Context;
using Resort.Models;
using Resort.Repo.IReponsitories;

namespace Resort.Repo.Reponsitories
{
	public class DistrictRepo : IDistrictRepo
	{
		private readonly IDistrictRepo _districtRepo;
		private readonly MyContext _myContext;
		public DistrictRepo(IDistrictRepo districtRepo, MyContext myContext)
		{
			_districtRepo = districtRepo;
			_myContext = myContext;
		}

		public Task<List<District>> GetAllDistrict()
		{
			throw new NotImplementedException();
		}

		public Task<List<District>> GetDistrictByID(int id)
		{
			throw new NotImplementedException();
		}
	}
}
