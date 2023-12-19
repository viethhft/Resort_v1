namespace Resort.Models
{
	public class Commune
	{
		public int IdCommune { get; set; }
		public string Name { get; set; }
		public int IdDistrict { get; set; }
		public virtual District District { get; set; }
		public virtual ICollection<Resort> Resort { get; set; }
	}
}
