using Resort.Models;

namespace Resort.Repo.IReponsitories
{
	public interface IDistrictRepo
	{
		public Task<List<District>> GetAllDistrict();
		public Task<List<District>> GetDistrictByID(int id);
	}
}
