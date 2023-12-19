using Resort.Context;
using Resort.Models;
using Resort.Repo.IReponsitories;

namespace Resort.Repo.Reponsitories
{
	public class TypeRoomRepo : ITypeRoomRepo
	{
		private readonly ITypeRoomRepo _typeRoomRepo;
		private readonly MyContext _myContext;
		public TypeRoomRepo(ITypeRoomRepo typeRoomRepo, MyContext myContext)
		{
			_typeRoomRepo = typeRoomRepo;
			_myContext = myContext;
		}

		public Task<bool> AddTypeRoom(TypeRoom typeRoom)
		{
			throw new NotImplementedException();
		}

		public Task<List<TypeRoom>> GetAllTypeRooms()
		{
			throw new NotImplementedException();
		}

		public Task<TypeRoom> GetTypeRoom(int id)
		{
			throw new NotImplementedException();
		}

		public Task<bool> RemoveTypeRoom(TypeRoom typeRoom)
		{
			throw new NotImplementedException();
		}

		public Task<bool> UpdateTypeRoom(TypeRoom typeRoom)
		{
			throw new NotImplementedException();
		}
	}
}
