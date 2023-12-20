using Resort.Models;
using Resort.Repo.IReponsitories;
using Resort.Ser.IServices;

namespace Resort.Ser.Services
{
    public class TypeRoomSer : ITypeRoomSer
    {
        private readonly ITypeRoomRepo _roomType;
        public TypeRoomSer(ITypeRoomRepo typeRoom)
        {
            _roomType=typeRoom;
        }
        public Task<bool> AddTypeRoom(TypeRoom typeRoom)
        {
            return _roomType.AddTypeRoom(typeRoom);
        }

        public Task<List<TypeRoom>> GetAllTypeRooms()
        {
            return _roomType.GetAllTypeRooms();
        }

        public Task<TypeRoom> GetTypeRoom(int id)
        {
            return _roomType.GetTypeRoom(id);
        }

        public Task<bool> RemoveTypeRoom(TypeRoom typeRoom)
        {
            return _roomType.RemoveTypeRoom(typeRoom);
        }

        public Task<bool> UpdateTypeRoom(TypeRoom typeRoom)
        {
            return _roomType.UpdateTypeRoom(typeRoom);
        }
    }
}
