using Resort.Models;

namespace Resort.Ser.IServices
{
	public interface IConvenientSer
	{
        public Task<List<Convenient>> GetAllConvenient();
        public Task<Convenient> GetConvenient(int id);
        public Task<bool> AddConvenient(Convenient convenient);
        public Task<bool> UpdateConvenient(Convenient convenient);
    }
}
