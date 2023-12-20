using Resort.Models;

namespace Resort.Ser.IServices
{
	public interface IResortDetailSer
	{
        public Task<ResortDetail> GetResortDetailByID(int id);
        public Task<bool> AddResortDetail(ResortDetail resortDetail);
        public Task<bool> UpdateResortDetail(ResortDetail resortDetail);
    }
}
