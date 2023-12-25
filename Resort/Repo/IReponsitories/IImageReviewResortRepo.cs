namespace Resort.Repo.IReponsitories
{
	public interface IImageReviewResortRepo
	{
		public Task<List<string>> GetListImageResortId(int id);
		public Task<bool> AddImage(int id,string image);
		public Task<bool> RemoveImage(int id,string image);
	}
}
