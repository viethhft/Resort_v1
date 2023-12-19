using Microsoft.EntityFrameworkCore;
using Resort.Context;
using Resort.Models;
using Resort.Repo.IReponsitories;

namespace Resort.Repo.Reponsitories
{
	public class TypeRoomResortDetailRepo : ITypeRoomResortDetailRepo
	{
		private readonly MyContext _myContext;
		public TypeRoomResortDetailRepo(MyContext myContext)
		{
			_myContext = myContext;
		}

		public async Task<bool> Add(TypeRoomResortDetail typeRoom)
		{
			try
			{
				await _myContext.TypeRoomResortDetails.AddAsync(typeRoom);
				await _myContext.SaveChangesAsync();
				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}

		public async Task<List<TypeRoomResortDetail>> GetListTypeRoomByIdResort(int id)
		{
			var lst = await _myContext.TypeRoomResortDetails.Where(c => c.IdResortDetail == id).ToListAsync();
			return lst;
		}

		public async Task<bool> Remove(TypeRoomResortDetail typeRoom)
		{
			try
			{
				_myContext.TypeRoomResortDetails.Remove(typeRoom);
				await _myContext.SaveChangesAsync();
				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}

		public async Task<bool> Update(TypeRoomResortDetail typeRoom)
		{
			try
			{
				_myContext.TypeRoomResortDetails.Remove(typeRoom);
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
