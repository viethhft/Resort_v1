namespace Resort.Models
{
	public class UserDetail
	{
		public int IdUserDetail { get; set; }
		public string UserName { get; set; }
		public string DoB { get; set; }
		public int Gender { get; set; }
		public string Description { get; set;}
		public string ImageProfile { get; set; }
		public int IdUser { get; set; }
		public virtual User User { get; set; }
	}
}
