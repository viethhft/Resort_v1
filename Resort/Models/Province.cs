namespace Resort.Models
{
	public class Province
	{
		public int IdProvince { get; set; }
		public string Name { get; set; }
		public ICollection<District> Districts { get; set; }
	}
}
