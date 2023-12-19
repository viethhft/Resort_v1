using Resort.Models;

namespace Resort.Repo.IReponsitories
{
	public interface IRoleRepo
	{
		public Task<Role> GetRoleById(int id);
		public Task<List<Role>> GetAllRole();
		public Task<bool> AddRole(Role role);
		public Task<bool> UpdateRole(Role role);
		public Task<bool> RemoveRole(Role role);
	}
}
