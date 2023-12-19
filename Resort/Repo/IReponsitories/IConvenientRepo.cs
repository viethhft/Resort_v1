using Resort.Models;

namespace Resort.Repo.IReponsitories
{
	public interface IConvenientRepo
	{
		public Task<List<Convenient>> GetAllConvenient();
		public Task<Convenient> GetConvenient(int id);
		public Task<bool> AddConvenient(Convenient convenient);
		public Task<bool> UpdateConvenient(Convenient convenient);
	}
}
