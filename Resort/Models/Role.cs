namespace Resort.Models
{
	public class Role
	{
		public int IdRole { get; set; }
		public string RoleName { get; set; }
		public virtual User User { get; set; }

	}
}
