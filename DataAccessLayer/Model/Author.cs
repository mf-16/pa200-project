namespace DataAccessLayer.Model
{
    public class Author : BaseEntity
    {
        public required string Name { get; set; }
        public string Bio { get; set; }
        public virtual ICollection<Book> Books { get; set; }
    }
}
