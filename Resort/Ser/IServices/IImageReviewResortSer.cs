namespace Resort.Ser.IServices
{
	public interface IImageReviewResortSer
	{
		public Task<List<string>> GetListImageResortId(int id);
		public Task<bool> AddImage(int id, string image);
		public Task<bool> RemoveImage(int id, string image);
	}
}
