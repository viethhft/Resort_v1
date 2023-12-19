using Microsoft.EntityFrameworkCore;
using Resort.Context;
using Resort.Models;
using Resort.Repo.IReponsitories;

namespace Resort.Repo.Reponsitories
{
	public class TypeRoomRepo : ITypeRoomRepo
	{
		private readonly MyContext _myContext;
		public TypeRoomRepo(MyContext myContext)
		{
			_myContext = myContext;
		}

		public async Task<bool> AddTypeRoom(TypeRoom typeRoom)
		{
			try
			{
				await _myContext.TypeRooms.AddAsync(typeRoom);
				await _myContext.SaveChangesAsync();
				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}

		public async Task<List<TypeRoom>> GetAllTypeRooms()
		{
			var lst = await _myContext.TypeRooms.ToListAsync();
			return lst;
		}

		public async Task<TypeRoom> GetTypeRoom(int id)
		{
			var t = await _myContext.TypeRooms.Where(c => c.IdTypeRoom == id).FirstOrDefaultAsync();
			return t;
		}

		public async Task<bool> RemoveTypeRoom(TypeRoom typeRoom)
		{
			try
			{
				_myContext.TypeRooms.Remove(typeRoom);
				await _myContext.SaveChangesAsync();
				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}

		public async Task<bool> UpdateTypeRoom(TypeRoom typeRoom)
		{
			try
			{
				_myContext.TypeRooms.Update(typeRoom);
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
