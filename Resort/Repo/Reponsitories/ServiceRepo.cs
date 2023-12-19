using Microsoft.EntityFrameworkCore;
using Resort.Context;
using Resort.Models;
using Resort.Repo.IReponsitories;

namespace Resort.Repo.Reponsitories
{
	public class ServiceRepo : IServiceRepo
	{
		private readonly MyContext _myContext;
		public ServiceRepo(MyContext myContext)
		{
			_myContext = myContext;
		}

		public async Task<bool> AddService(Service service)
		{
			try
			{
				await _myContext.Services.AddAsync(service);
				await _myContext.SaveChangesAsync();
				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}

		public async Task<List<Service>> GetAllServices()
		{
			var lst = await _myContext.Services.ToListAsync();
			return lst;
		}

		public async Task<Service> GetServicesById(int id)
		{
			var ser=await _myContext.Services.Where(c=>c.IdService==id).FirstOrDefaultAsync();
			return ser;
		}

		public async Task<bool> RemoveService(Service service)
		{
			try
			{
				_myContext.Services.Remove(service);
				await _myContext.SaveChangesAsync();
				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}

		public async Task<bool> UpdateService(Service service)
		{
			try
			{
				_myContext.Services.Update(service);
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
