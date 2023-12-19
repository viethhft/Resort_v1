using Resort.Context;
using Resort.Models;
using Resort.Repo.IReponsitories;

namespace Resort.Repo.Reponsitories
{
	public class RoleRepo : IRoleRepo
	{
		private readonly IRoleRepo _roleRepo;
		private readonly MyContext _myContext;
		public RoleRepo(IRoleRepo roleRepo, MyContext myContext)
		{
			_roleRepo = roleRepo;
			_myContext = myContext;
		}

		public Task<bool> AddRole(Role role)
		{
			throw new NotImplementedException();
		}

		public Task<List<Role>> GetAllRole()
		{
			throw new NotImplementedException();
		}

		public Task<Role> GetRoleById(int id)
		{
			throw new NotImplementedException();
		}

		public Task<bool> RemoveRole(Role role)
		{
			throw new NotImplementedException();
		}

		public Task<bool> UpdateRole(Role role)
		{
			throw new NotImplementedException();
		}
	}
}
