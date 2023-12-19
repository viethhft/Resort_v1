using Microsoft.EntityFrameworkCore;
using Resort.Context;
using Resort.Models;
using Resort.Repo.IReponsitories;

namespace Resort.Repo.Reponsitories
{
	public class ConvenientRepo : IConvenientRepo
	{
		private readonly MyContext _myContext;
		public ConvenientRepo(MyContext myContext)
		{
			_myContext = myContext;
		}

		public async Task<bool> AddConvenient(Convenient convenient)
		{
			try
			{
				await _myContext.Convenients.AddAsync(convenient);
				await _myContext.SaveChangesAsync();
				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}

		public async Task<List<Convenient>> GetAllConvenient()
		{
			var lst = await _myContext.Convenients.ToListAsync();
			return lst;
		}

		public async Task<Convenient> GetConvenient(int id)
		{
			var conven = await _myContext.Convenients.Where(c => c.IdConvenient == id).FirstOrDefaultAsync();
			return conven;
		}

		public async Task<bool> UpdateConvenient(Convenient convenient)
		{
			try
			{
				 _myContext.Convenients.Update(convenient);
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
