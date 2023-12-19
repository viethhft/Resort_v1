namespace Resort.Models
{
	public class Service
	{
		public int IdService { get; set; }
		public string NameService { get; set; }
		public virtual ICollection<ResortDetailServices> ResortDetailServices { get; set;}
	}
}
