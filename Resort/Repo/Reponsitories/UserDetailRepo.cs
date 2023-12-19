using Resort.Context;
using Resort.Models;
using Resort.Repo.IReponsitories;

namespace Resort.Repo.Reponsitories
{
	public class UserDetailRepo : IUserDetailRepo
	{
		private readonly IUserDetailRepo _userDetailRepo;
		private readonly MyContext _myContext;
		public UserDetailRepo(IUserDetailRepo userDetailRepo, MyContext myContext)
		{
			_userDetailRepo = userDetailRepo;
			_myContext = myContext;
		}

		public Task<bool> AddUser(User user)
		{
			throw new NotImplementedException();
		}

		public Task<User> GetUserByEmailAndPass(string email, string pass)
		{
			throw new NotImplementedException();
		}

		public Task<User> GetUserById(int id)
		{
			throw new NotImplementedException();
		}

		public Task<bool> UpdateUser(User user)
		{
			throw new NotImplementedException();
		}
	}
}
