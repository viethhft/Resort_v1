using Resort.Models;
using Resort.Repo.IReponsitories;
using Resort.Ser.IServices;

namespace Resort.Ser.Services
{
    public class RoleSer : IRoleSer
    {
        private readonly IRoleRepo _roleRepo;
        public RoleSer(IRoleRepo roleRepo)
        {
            _roleRepo = roleRepo;
        }
        public Task<bool> AddRole(Role role)
        {
            return _roleRepo.AddRole(role);
        }

        public Task<List<Role>> GetAllRole()
        {
            return _roleRepo.GetAllRole();
        }

        public Task<Role> GetRoleById(int id)
        {
            return _roleRepo.GetRoleById(id);
        }

        public Task<bool> RemoveRole(Role role)
        {
            return _roleRepo.RemoveRole(role);
        }

        public Task<bool> UpdateRole(Role role)
        {
            return _roleRepo.UpdateRole(role);
        }
    }
}
