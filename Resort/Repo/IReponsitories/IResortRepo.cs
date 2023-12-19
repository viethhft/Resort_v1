using Resort.Models;

namespace Resort.Repo.IReponsitories
{
	public interface IResortRepo
	{
		public Task<List<Resort.Models.Resort>> GetAllResort();
		public Task<bool> AddResort(Resort.Models.Resort resort);
		public Task<bool> UpdateResort(Resort.Models.Resort resort);
	}
}
