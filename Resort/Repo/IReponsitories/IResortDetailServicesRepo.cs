using Resort.Models;

namespace Resort.Repo.IReponsitories
{
	public interface IResortDetailServicesRepo
	{
		public Task<List<ResortDetailServices>> GetListByIdResort(int id);
		public Task<bool> Add(ResortDetailServices service);
		public Task<bool> Update(ResortDetailServices services);
	}
}
