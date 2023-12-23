namespace Resort.Models
{
	public class User
	{
		public int IdUser { get; set; }
		public string Email { get; set; }
		public string Password { get; set; }
		public int Status { get; set; }
		public int IdRole { get; set; }
		public bool Remember { get; set; }
		public virtual Role Role { get; set; }
		public virtual UserDetail UserDetail { get; set; }
		public virtual ICollection<Rate> Rates { get; set; }
		public virtual ICollection<Resort> Resorts { get; set; }
	}
}
