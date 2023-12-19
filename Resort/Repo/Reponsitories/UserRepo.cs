using Microsoft.EntityFrameworkCore;
using Resort.Context;
using Resort.Models;
using Resort.Repo.IReponsitories;

namespace Resort.Repo.Reponsitories
{
	public class UserRepo : IUserRepo
	{
		private readonly MyContext _myContext;
		public UserRepo(MyContext myContext)
		{
			_myContext = myContext;
		}

		public async Task<bool> AddUser(User user)
		{
			try
			{
				await _myContext.Users.AddAsync(user);
				await _myContext.SaveChangesAsync();
				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}

		public async Task<User> GetUserByEmailAndPass(string email, string pass)
		{
			var user =await _myContext.Users.Where(c=>c.Email==email&& c.Password==pass).FirstOrDefaultAsync();
			return user;
		}

		public async Task<User> GetUserById(int id)
		{
			var user= await _myContext.Users.Where(c=>c.IdUser==id).FirstOrDefaultAsync();
			return user;
		}

		public async Task<bool> UpdateUser(User user)
		{
			try
			{
				_myContext.Users.Update(user);
				await _myContext.SaveChangesAsync();
				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}
	}
}
