using Resort.Models;

namespace Resort.Ser.IServices
{
	public interface IDistrictSer
	{
        public Task<List<District>> GetAllDistrict();
        public Task<List<District>> GetDistrictByID(int id);
    }
}
