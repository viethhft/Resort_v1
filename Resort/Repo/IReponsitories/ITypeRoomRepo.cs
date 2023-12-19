using Resort.Models;

namespace Resort.Repo.IReponsitories
{
	public interface ITypeRoomRepo
	{
		public Task<List<TypeRoom>> GetAllTypeRooms();
		public Task<TypeRoom> GetTypeRoom(int id);
		public Task<bool> AddTypeRoom(TypeRoom typeRoom);
		public Task<bool> UpdateTypeRoom(TypeRoom typeRoom);
		public Task<bool> RemoveTypeRoom(TypeRoom typeRoom);
	}
}
