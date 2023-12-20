using Resort.Models;

namespace Resort.Ser.IServices
{
	public interface IUserDetailSer
	{
        public Task<UserDetail> GetUserDetailByIdUser(int id);
        public Task<bool> AddUserDetail(UserDetail user);
        public Task<bool> UpdateUserDetail(UserDetail user);
    }
}
