using Resort.Models;

namespace Resort.Ser.IServices
{
	public interface ITypeRoomResortDetailSer
	{
        public Task<List<TypeRoomResortDetail>> GetListTypeRoomByIdResort(int id);
        public Task<bool> Add(TypeRoomResortDetail typeRoom);
        public Task<bool> Update(TypeRoomResortDetail typeRoom);
        public Task<bool> Remove(TypeRoomResortDetail typeRoom);
    }
}
