namespace Resort.Models
{
	public class ResortDetail
	{
		public int IdResortDetail { get; set; }
		public string Description { get; set; }
		public int IdResort { get; set; }
		public string AddressDetail { get; set; }
		public string ListImage { get; set; }
		public virtual Resort Resort { get; set; }
		public virtual ICollection<TypeRoomResortDetail> TypeRoomResortDetails { get; set; }
		public virtual ICollection<ResortDetailServices> ResortDetailServices { get; set; }
	}
}
