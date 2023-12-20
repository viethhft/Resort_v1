namespace Resort.Ser.IServices
{
	public interface IResortSer
	{
        public Task<List<Resort.Models.Resort>> GetAllResort();
        public Task<bool> AddResort(Resort.Models.Resort resort);
        public Task<bool> UpdateResort(Resort.Models.Resort resort);
    }
}
