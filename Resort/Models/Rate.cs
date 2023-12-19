namespace Resort.Models
{
	public class Rate
	{
		public int IdResort { get; set; }
		public int IdUser { get; set; }
		public int RateStar { get; set; }
		public virtual User User { get; set; }
		public virtual Resort Resort { get; set; }
	}
}
