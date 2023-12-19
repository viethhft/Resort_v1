using Resort.Models;

namespace Resort.Repo.IReponsitories
{
	public interface IResortDetailRepo
	{
		public Task<ResortDetail> GetResortDetailByID(int id);
		public Task<bool> AddResortDetail(ResortDetail resortDetail);
		public Task<bool> UpdateResortDetail(ResortDetail resortDetail);
	}
}
