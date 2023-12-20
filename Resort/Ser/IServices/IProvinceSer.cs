using Resort.Models;

namespace Resort.Ser.IServices
{
	public interface IProvinceSer
	{
        public Task<List<Province>> GetAllProvince();
        public Task<Province> GetProvinceByID(int id);
    }
}
