namespace Resort.Models
{
	public class ImageReviewResort
	{
		public int IdImage { get; set; }
		public int IdResort { get; set; }
		public string Image { get; set; }
		public virtual Resort Resort { get; set; }
	}
}
