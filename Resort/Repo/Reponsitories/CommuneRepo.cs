using Microsoft.EntityFrameworkCore;
using Resort.Context;
using Resort.Models;
using Resort.Repo.IReponsitories;

namespace Resort.Repo.Reponsitories
{
	public class CommuneRepo : ICommuneRepo
	{
		private readonly MyContext _myContext;
		public CommuneRepo(MyContext myContext)
		{
			_myContext = myContext;
		}

		public async Task<List<Commune>> GetAllCommune()
		{
			List<Commune> lst= await _myContext.Communes.ToListAsync();
			return lst;
		}

		public async Task<Commune> GetCommuneByID(int id)
		{
			var commune = await _myContext.Communes.Where(c => c.IdDistrict == id).FirstOrDefaultAsync();
			return commune;
		}
	}
}
