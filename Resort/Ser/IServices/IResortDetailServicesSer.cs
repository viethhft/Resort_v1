using Resort.Models;

namespace Resort.Ser.IServices
{
	public interface IResortDetailServicesSer
	{
        public Task<List<ResortDetailServices>> GetListByIdResort(int id);
        public Task<bool> Add(ResortDetailServices service);
        public Task<bool> Update(ResortDetailServices services);
        public Task<bool> Remove(ResortDetailServices services);
    }
}
