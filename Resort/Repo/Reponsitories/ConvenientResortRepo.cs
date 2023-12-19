using Microsoft.EntityFrameworkCore;
using Resort.Context;
using Resort.Models;
using Resort.Repo.IReponsitories;

namespace Resort.Repo.Reponsitories
{
	public class ConvenientResortRepo : IConvenientResortRepo
	{
		private readonly MyContext _myContext;
		public ConvenientResortRepo(MyContext myContext)
		{
			_myContext = myContext;
		}

		public async Task<bool> Add(ConvenientResort convenientResort)
		{
			try
			{
				await _myContext.ConvenientResorts.AddAsync(convenientResort);
				await _myContext.SaveChangesAsync();
				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}

		public async Task<List<ConvenientResort>> GetConvenientByIdResort(int id)
		{
			var lst =await _myContext.ConvenientResorts.Where(c => c.IdResort == id).ToListAsync();
			return lst;
		}

		public async Task<bool> Remove(ConvenientResort convenientResort)
		{
			try
			{
				_myContext.ConvenientResorts.Remove(convenientResort);
				await _myContext.SaveChangesAsync();
				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}

		public async Task<bool> Update(ConvenientResort convenientResort)
		{
			try
			{
				_myContext.ConvenientResorts.Update(convenientResort);
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
