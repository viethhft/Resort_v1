using Microsoft.EntityFrameworkCore;
using Resort.Context;
using Resort.Models;
using Resort.Repo.IReponsitories;

namespace Resort.Repo.Reponsitories
{
	public class ImageReviewResortRepo : IImageReviewResortRepo
	{
		private readonly MyContext _myContext;
		public ImageReviewResortRepo(MyContext myContext)
		{
			_myContext = myContext;
		}

		public async Task<bool> AddImage(int id, string image)
		{
			try
			{
				var imageReview = new ImageReviewResort() { IdResort = id, Image = image };
				await _myContext.ImageReviewResorts.AddAsync(imageReview);
				await _myContext.SaveChangesAsync();
				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}

		public async Task<List<string>> GetListImageResortId(int id)
		{
			List<string> list = new List<string>();
			foreach (var item in await _myContext.ImageReviewResorts.Where(c=>c.IdResort==id).ToListAsync())
			{
				list.Add(item.Image);
			}
			return list;
		}

		public async Task<bool> RemoveImage(int id, string image)
		{
			try
			{
				var imageReview = await _myContext.ImageReviewResorts.Where(c=>c.IdResort== id&& c.Image==image).FirstOrDefaultAsync();
				_myContext.ImageReviewResorts.Remove(imageReview);
				_myContext.SaveChanges();
				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}
	}
}
