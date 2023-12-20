using Resort.Models;
using Resort.Repo.IReponsitories;
using Resort.Ser.IServices;

namespace Resort.Ser.Services
{
    public class TypeRoomResortDetailSer : ITypeRoomResortDetailSer
    {
        private readonly ITypeRoomResortDetailRepo _typeRoomResortDetailRepo;
        public TypeRoomResortDetailSer(ITypeRoomResortDetailRepo typeRoomResortDetailRepo)
        {
            _typeRoomResortDetailRepo = typeRoomResortDetailRepo;
        }
        public Task<bool> Add(TypeRoomResortDetail typeRoom)
        {
            return _typeRoomResortDetailRepo.Add(typeRoom);
        }

        public Task<List<TypeRoomResortDetail>> GetListTypeRoomByIdResort(int id)
        {
            return _typeRoomResortDetailRepo.GetListTypeRoomByIdResort(id);
        }

        public Task<bool> Remove(TypeRoomResortDetail typeRoom)
        {
            return _typeRoomResortDetailRepo.Remove(typeRoom);
        }

        public Task<bool> Update(TypeRoomResortDetail typeRoom)
        {
            return _typeRoomResortDetailRepo.Update(typeRoom);
        }
    }
}
