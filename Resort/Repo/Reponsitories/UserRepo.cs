using Resort.Context;
using Resort.Models;
using Resort.Repo.IReponsitories;

namespace Resort.Repo.Reponsitories
{
	public class UserRepo : IUserRepo
	{
		private readonly IUserRepo _userRepo;
		private readonly MyContext _myContext;
		public UserRepo(IUserRepo userRepo, MyContext myContext)
		{
			_userRepo = userRepo;
			_myContext = myContext;
		}

		public Task<bool> AddUserDetail(UserDetail user)
		{
			throw new NotImplementedException();
		}

		public Task<UserDetail> GetUserDetailByIdUser(int id)
		{
			throw new NotImplementedException();
		}

		public Task<bool> UpdateUserDetail(UserDetail user)
		{
			throw new NotImplementedException();
		}
	}
}
