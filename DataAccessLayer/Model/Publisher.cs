namespace DataAccessLayer.Model
{
    public class Publisher : BaseEntity
    {
        public required string Name { get; set; }
        public string Bio { get; set; } 

        public ICollection<Book> Books { get; set; }
    }
}
