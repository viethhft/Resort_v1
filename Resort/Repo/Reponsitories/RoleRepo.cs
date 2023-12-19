using Microsoft.EntityFrameworkCore;
using Resort.Context;
using Resort.Models;
using Resort.Repo.IReponsitories;

namespace Resort.Repo.Reponsitories
{
	public class RoleRepo : IRoleRepo
	{
		private readonly MyContext _myContext;
		public RoleRepo(MyContext myContext)
		{
			_myContext = myContext;
		}

		public async Task<bool> AddRole(Role role)
		{
			try
			{
				await _myContext.Roles.AddAsync(role);
				await _myContext.SaveChangesAsync();
				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}

		public async Task<List<Role>> GetAllRole()
		{
			var lst = await _myContext.Roles.ToListAsync();
			return lst;
		}

		public Task<Role> GetRoleById(int id)
		{
			var role = _myContext.Roles.Where(c => c.IdRole == id).FirstOrDefaultAsync();
			return role;
		}

		public async Task<bool> RemoveRole(Role role)
		{
			try
			{
				_myContext.Roles.Remove(role);
				await _myContext.SaveChangesAsync();
				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}

		public async Task<bool> UpdateRole(Role role)
		{
			try
			{
				_myContext.Roles.Update(role);
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
