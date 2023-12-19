using Microsoft.EntityFrameworkCore;
using Resort.Context;
using Resort.Models;
using Resort.Repo.IReponsitories;

namespace Resort.Repo.Reponsitories
{
	public class DistrictRepo : IDistrictRepo
	{
		private readonly MyContext _myContext;
		public DistrictRepo(MyContext myContext)
		{
			_myContext = myContext;
		}

		public async Task<List<District>> GetAllDistrict()
		{
			var lst = await _myContext.Districts.ToListAsync();
			return lst;
		}

		public async Task<List<District>> GetDistrictByID(int id)
		{
			var list = await _myContext.Districts.Where(c => c.IdProvince == id).ToListAsync();
			return list;
		}
	}
}
