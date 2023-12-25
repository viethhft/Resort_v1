using Microsoft.EntityFrameworkCore;
using Resort.Context;
using Resort.Models;
using Resort.Repo.IReponsitories;
using Resort.Validate;

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

		public async Task<bool> GetUserByEmail(string email)
		{
			var user=await _myContext.Users.Where(c=>c.Email==email).FirstOrDefaultAsync();
			if (user!=null)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		public async Task<User> GetUserByEmailAndPass(string email, string pass)
		{
			var user = await _myContext.Users.Where(c => c.Email == email && c.Password == ValidateRegex.ReversePass(pass)).AsNoTracking().FirstOrDefaultAsync();
			return user;
		}

		public async Task<User> GetUserById(int id)
		{
			var user = await _myContext.Users.Where(c => c.IdUser == id).AsNoTracking().FirstOrDefaultAsync();
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
