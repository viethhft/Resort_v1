using Microsoft.EntityFrameworkCore;
using Resort.Context;
using Resort.Models;
using Resort.Repo.IReponsitories;

namespace Resort.Repo.Reponsitories
{
	public class ResortDetailServicesRepo : IResortDetailServicesRepo
	{
		private readonly MyContext _myContext;
		public ResortDetailServicesRepo(MyContext myContext)
		{
			_myContext = myContext;
		}

		public async Task<bool> Add(ResortDetailServices service)
		{
			try
			{
				await _myContext.ResortDetailServices.AddAsync(service);
				await _myContext.SaveChangesAsync();
				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}

		public async Task<List<ResortDetailServices>> GetListByIdResort(int id)
		{
			var lst = await _myContext.ResortDetailServices.Where(c => c.IdResortDetail == id).ToListAsync();
			return lst;
		}

		public async Task<bool> Remove(ResortDetailServices services)
		{
			try
			{
				_myContext.ResortDetailServices.Remove(services);
				await _myContext.SaveChangesAsync();
				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}

		public async Task<bool> Update(ResortDetailServices services)
		{
			try
			{
				_myContext.ResortDetailServices.Remove(services);
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
