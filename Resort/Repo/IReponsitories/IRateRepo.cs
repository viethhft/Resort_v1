using Resort.Models;

namespace Resort.Repo.IReponsitories
{
	public interface IRateRepo
	{
		public Task<List<Rate>> GetListRateByIdResort();
		public Task<bool> AddRate(Rate rate);
		public Task<bool> UpdateRate(Rate rate);
		public Task<bool> RemoveRate(Rate rate);
	}
}
