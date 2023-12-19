namespace Resort.Models
{
	public class Resort
	{
		public int IdResort { get; set; }
		public string Title { get; set; }
		public string Name { get; set; }
		public string Thumb { get; set; }
		public string Description { get; set; }
		public int Status { get; set; }
		public int IdCommune { get; set; }
		public virtual Commune Commune { get; set; }
		public virtual ResortDetail ResortDetail { get; set; }
		public virtual ICollection<Rate> Rates { get; set; }
		public virtual ICollection<ConvenientResort> ConvenientResorts { get; set; }
	}
}
