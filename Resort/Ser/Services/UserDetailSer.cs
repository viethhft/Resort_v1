using Resort.Models;
using Resort.Repo.IReponsitories;
using Resort.Ser.IServices;

namespace Resort.Ser.Services
{
    public class UserDetailSer : IUserDetailSer
    {
        private readonly IUserDetailRepo _userDetailRepo;
        public UserDetailSer(IUserDetailRepo userDetailRepo)
        {
            _userDetailRepo = userDetailRepo;
        }

        public Task<bool> AddUserDetail(UserDetail user)
        {
            return _userDetailRepo.AddUserDetail(user);
        }

        public Task<UserDetail> GetUserDetailByIdUser(int id)
        {
            return _userDetailRepo.GetUserDetailByIdUser(id);
        }

        public Task<bool> UpdateUserDetail(UserDetail user)
        {
            return _userDetailRepo.UpdateUserDetail(user);
        }
    }
}
