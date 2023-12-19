using Microsoft.EntityFrameworkCore;
using Resort.Context;
using Resort.Models;
using Resort.Repo.IReponsitories;

namespace Resort.Repo.Reponsitories
{
	public class ResortRepo : IResortRepo
	{
		private readonly MyContext _myContext;
		public ResortRepo(MyContext myContext)
		{
			_myContext = myContext;
		}

		public async Task<bool> AddResort(Models.Resort resort)
		{
			try
			{
				await _myContext.Resorts.AddAsync(resort);
				await _myContext.SaveChangesAsync();
				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}

		public async Task<List<Models.Resort>> GetAllResort()
		{
			var lst=await _myContext.Resorts.ToListAsync();
			return lst;
		}

		public async Task<bool> UpdateResort(Models.Resort resort)
		{
			try
			{
				_myContext.Resorts.Update(resort);
				await _myContext.SaveChangesAsync();
				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}
	}
}
