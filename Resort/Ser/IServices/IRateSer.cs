using Resort.Models;

namespace Resort.Ser.IServices
{
	public interface IRateSer
	{
        public Task<List<Rate>> GetListRateByIdResort(int id);
        public Task<bool> AddRate(Rate rate);
        public Task<bool> UpdateRate(Rate rate);
        public Task<bool> RemoveRate(Rate rate);
    }
}
