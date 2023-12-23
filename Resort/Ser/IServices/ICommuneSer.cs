using Resort.Models;

namespace Resort.Ser.IServices
{
	public interface ICommuneSer
	{
        public Task<List<Commune>> GetAllCommune();
        public Task<List<Commune>> GetCommuneByID(int id);
    }
}
