using Resort.Context;
using Resort.Models;
using Resort.Repo.IReponsitories;

namespace Resort.Repo.Reponsitories
{
	public class ProvinceRepo : IProvinceRepo
	{
		private readonly IProvinceRepo _provinceRepo;
		private readonly MyContext _myContext;
		public ProvinceRepo(IProvinceRepo provinceRepo, MyContext myContext)
		{
			_provinceRepo = provinceRepo;
			_myContext = myContext;
		}

		public Task<List<Province>> GetAllProvince()
		{
			throw new NotImplementedException();
		}

		public Task<List<Province>> GetProvinceByID(int id)
		{
			throw new NotImplementedException();
		}
	}
}
