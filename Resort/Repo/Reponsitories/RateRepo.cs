using Microsoft.EntityFrameworkCore;
using Resort.Context;
using Resort.Models;
using Resort.Repo.IReponsitories;

namespace Resort.Repo.Reponsitories
{
	public class RateRepo : IRateRepo
	{
		private readonly MyContext _myContext;
		public RateRepo(MyContext myContext)
		{
			_myContext = myContext;
		}

		public async Task<bool> AddRate(Rate rate)
		{
			try
			{
				await _myContext.Rates.AddAsync(rate);
				await _myContext.SaveChangesAsync();
				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}

		public async Task<List<Rate>> GetListRateByIdResort(int id)
		{
			var lst=await _myContext.Rates.Where(c=>c.IdResort== id).ToListAsync();
			return lst;
		}

		public async Task<bool> RemoveRate(Rate rate)
		{
			try
			{
				 _myContext.Rates.Remove(rate);
				await _myContext.SaveChangesAsync();
				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}

		public async Task<bool> UpdateRate(Rate rate)
		{
			try
			{
				_myContext.Rates.Update(rate);
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
