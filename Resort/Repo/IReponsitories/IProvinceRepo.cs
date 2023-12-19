using Resort.Models;

namespace Resort.Repo.IReponsitories
{
	public interface IProvinceRepo
	{
		public Task<List<Province>> GetAllProvince ();
		public Task<List<Province>> GetProvinceByID(int id);
	}
}
