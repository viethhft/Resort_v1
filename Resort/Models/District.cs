namespace Resort.Models
{
	public class District
	{
		public int IdDistrict { get; set; }
		public string Name { get; set; }
		public int IdProvince { get; set; }
		public virtual Province Province { get; set; }
		public virtual ICollection<Commune> Communes { get; set; }
	}
}
