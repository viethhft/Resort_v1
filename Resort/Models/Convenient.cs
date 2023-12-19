namespace Resort.Models
{
	public class Convenient
	{
		public int IdConvenient { get; set; }
		public string Name { get; set; }
		public virtual ICollection<ConvenientResort> ConvenientResorts { get;set; } 
	}
}
