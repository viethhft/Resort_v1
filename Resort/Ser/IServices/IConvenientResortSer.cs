using Resort.Models;

namespace Resort.Ser.IServices
{
	public interface IConvenientResortSer
	{
        public Task<List<ConvenientResort>> GetConvenientByIdResort(int id);
        public Task<bool> Add(ConvenientResort convenientResort);
        public Task<bool> Update(ConvenientResort convenientResort);
        public Task<bool> Remove(ConvenientResort convenientResort);
    }
}
