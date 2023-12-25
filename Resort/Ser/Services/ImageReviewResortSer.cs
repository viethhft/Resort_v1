using Resort.Repo.IReponsitories;
using Resort.Ser.IServices;

namespace Resort.Ser.Services
{
	public class ImageReviewResortSer : IImageReviewResortSer
	{
		private readonly IImageReviewResortRepo _imageReviewResortRepo;
		public ImageReviewResortSer(IImageReviewResortRepo imageReviewResortRepo)
		{
			_imageReviewResortRepo = imageReviewResortRepo;
		}

		public async Task<bool> AddImage(int id, string image)
		{
			return await _imageReviewResortRepo.AddImage(id, image);
		}

		public async Task<List<string>> GetListImageResortId(int id)
		{
			return await _imageReviewResortRepo.GetListImageResortId(id);
		}

		public async Task<bool> RemoveImage(int id, string image)
		{
			return await _imageReviewResortRepo.RemoveImage(id, image);
		}
	}
}
