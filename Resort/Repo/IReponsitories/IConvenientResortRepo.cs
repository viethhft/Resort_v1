using Resort.Models;

namespace Resort.Repo.IReponsitories
{
	public interface IConvenientResortRepo
	{
		public Task<List<ConvenientResort>> GetConvenientByIdResort(int id);
		public Task<bool> Add(ConvenientResort convenientResort);
		public Task<bool> Update(ConvenientResort convenientResort);
		public Task<bool> Remove(ConvenientResort convenientResort);
	}
}
