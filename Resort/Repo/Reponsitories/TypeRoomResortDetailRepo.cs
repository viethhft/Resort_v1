using Resort.Context;
using Resort.Models;
using Resort.Repo.IReponsitories;

namespace Resort.Repo.Reponsitories
{
	public class TypeRoomResortDetailRepo : ITypeRoomResortDetailRepo
	{
		private readonly ITypeRoomResortDetailRepo _typeRoomResortDetailRepo;
		private readonly MyContext _myContext;
		public TypeRoomResortDetailRepo(ITypeRoomResortDetailRepo typeRoomResortDetailRepo, MyContext myContext)
		{
			_typeRoomResortDetailRepo = typeRoomResortDetailRepo;
			_myContext = myContext;
		}

		public Task<bool> Add(TypeRoomResortDetail typeRoom)
		{
			throw new NotImplementedException();
		}

		public Task<List<TypeRoomResortDetail>> GetListTypeRoomByIdResort(int id)
		{
			throw new NotImplementedException();
		}

		public Task<bool> Remove(TypeRoomResortDetail typeRoom)
		{
			throw new NotImplementedException();
		}

		public Task<bool> Update(TypeRoomResortDetail typeRoom)
		{
			throw new NotImplementedException();
		}
	}
}
