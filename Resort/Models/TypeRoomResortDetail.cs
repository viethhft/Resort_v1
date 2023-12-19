namespace Resort.Models
{
	public class TypeRoomResortDetail
	{
		public int IdTypeRoom { get; set; }
		public int IdResortDetail { get; set; }
		public virtual TypeRoom TypeRoom { get; set; }
		public virtual ResortDetail ResortDetail { get; set; }

	}
}
