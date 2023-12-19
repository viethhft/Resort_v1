using Resort.Models;

namespace Resort.Repo.IReponsitories
{
	public interface IUserDetailRepo
	{
		public Task<UserDetail> GetUserDetailByIdUser(int id);
		public Task<bool> AddUserDetail(UserDetail user);
		public Task<bool> UpdateUserDetail(UserDetail user);
	}
}
