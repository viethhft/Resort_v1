using Resort.Models;

namespace Resort.Repo.IReponsitories
{
	public interface IUserRepo
	{
		public Task<UserDetail> GetUserDetailByIdUser(int id);
		public Task<bool> AddUserDetail(UserDetail user);
		public Task<bool> UpdateUserDetail(UserDetail user);
	}
}
