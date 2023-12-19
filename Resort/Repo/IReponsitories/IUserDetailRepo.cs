using Resort.Models;

namespace Resort.Repo.IReponsitories
{
	public interface IUserDetailRepo
	{
		public Task<User> GetUserById(int id);
		public Task<User> GetUserByEmailAndPass(string email,string pass);
		public Task<bool> AddUser(User user);
		public Task<bool> UpdateUser(User user);
	}
}
