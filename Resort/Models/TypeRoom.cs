namespace Resort.Models
{
	public class TypeRoom
	{
		public int IdTypeRoom { get; set; }
		public string Name { get; set; }
		public virtual ICollection<TypeRoomResortDetail> TypeRoomResortDetails { get; set; }
	}
}
