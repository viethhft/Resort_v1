using Resort.Models;

namespace Resort.Ser.IServices
{
	public interface ITypeRoomSer
	{
        public Task<List<TypeRoom>> GetAllTypeRooms();
        public Task<TypeRoom> GetTypeRoom(int id);
        public Task<bool> AddTypeRoom(TypeRoom typeRoom);
        public Task<bool> UpdateTypeRoom(TypeRoom typeRoom);
        public Task<bool> RemoveTypeRoom(TypeRoom typeRoom);
    }
}
