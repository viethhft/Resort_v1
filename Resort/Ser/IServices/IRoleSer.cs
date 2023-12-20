using Resort.Models;

namespace Resort.Ser.IServices
{
	public interface IRoleSer
	{
        public Task<Role> GetRoleById(int id);
        public Task<List<Role>> GetAllRole();
        public Task<bool> AddRole(Role role);
        public Task<bool> UpdateRole(Role role);
        public Task<bool> RemoveRole(Role role);
    }
}
