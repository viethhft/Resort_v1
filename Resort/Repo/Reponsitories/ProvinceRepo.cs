using Microsoft.EntityFrameworkCore;
using Resort.Context;
using Resort.Models;
using Resort.Repo.IReponsitories;

namespace Resort.Repo.Reponsitories
{
	public class ProvinceRepo : IProvinceRepo
	{
		private readonly MyContext _myContext;
		public ProvinceRepo(MyContext myContext)
		{
			_myContext = myContext;
		}

		public async Task<List<Province>> GetAllProvince()
		{
			var lst = await _myContext.Provinces.ToListAsync();
			return lst;
		}

		public async Task<Province> GetProvinceByID(int id)
		{
			var lst=await _myContext.Provinces.Where(c=>c.IdProvince==id).FirstOrDefaultAsync();
			return lst;

		}
	}
}
