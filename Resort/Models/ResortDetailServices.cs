namespace Resort.Models
{
	public class ResortDetailServices
	{
		public int IdResortDetail { get; set; }
		public int IdService { get; set; }
		public virtual ResortDetail ResortDetail { get; set; }
		public virtual Service Service { get; set; }
	}
}
