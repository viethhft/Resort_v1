﻿using Microsoft.EntityFrameworkCore;
using Resort.Context;
using Resort.Models;
using Resort.Repo.IReponsitories;

namespace Resort.Repo.Reponsitories
{
	public class UserDetailRepo : IUserDetailRepo
	{
		private readonly MyContext _myContext;
		public UserDetailRepo(MyContext myContext)
		{
			_myContext = myContext;
		}

		public async Task<bool> AddUserDetail(UserDetail user)
		{
			try
			{
				await _myContext.UserDetails.AddAsync(user);
				await _myContext.SaveChangesAsync();
				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}

		public async Task<UserDetail> GetUserDetailByIdUser(int id)
		{
			var lst=await _myContext.UserDetails.Where(c=>c.IdUser== id).FirstOrDefaultAsync();
			return lst;
		}

		public async Task<bool> UpdateUserDetail(UserDetail user)
		{
			try
			{
				_myContext.UserDetails.Update(user);
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
