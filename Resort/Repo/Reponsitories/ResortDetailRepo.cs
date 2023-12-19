using Microsoft.EntityFrameworkCore;
using Resort.Context;
using Resort.Models;
using Resort.Repo.IReponsitories;

namespace Resort.Repo.Reponsitories
{
	public class ResortDetailRepo : IResortDetailRepo
	{
		private readonly MyContext _myContext;
		public ResortDetailRepo(MyContext myContext)
		{
			_myContext = myContext;
		}

		public async Task<bool> AddResortDetail(ResortDetail resortDetail)
		{
			try
			{
				await _myContext.ResortDetails.AddAsync(resortDetail);
				await _myContext.SaveChangesAsync();
				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}

		public async Task<ResortDetail> GetResortDetailByID(int id)
		{
			var lst = await _myContext.ResortDetails.Where(c => c.IdResort == id).FirstOrDefaultAsync();
			return lst;
		}

		public async Task<bool> UpdateResortDetail(ResortDetail resortDetail)
		{
			try
			{
				_myContext.ResortDetails.Update(resortDetail);
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
