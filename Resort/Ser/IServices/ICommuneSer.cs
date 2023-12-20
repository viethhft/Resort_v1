using Resort.Models;

namespace Resort.Ser.IServices
{
	public interface ICommuneSer
	{
        public Task<List<Commune>> GetAllCommune();
        public Task<Commune> GetCommuneByID(int id);
    }
}
