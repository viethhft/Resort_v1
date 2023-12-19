using Resort.Models;

namespace Resort.Repo.IReponsitories
{
	public interface ICommuneRepo
	{
		public Task<List<Commune>> GetAllCommune();
		public Task<Commune> GetCommuneByID(int id);
	}
}
