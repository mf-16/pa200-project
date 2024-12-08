namespace DataAccessLayer.Model;

public class BookGenre
{
    public int Id { get; set; }
    public string Name { get; set; }
    public virtual ICollection<Book> PrimaryBooks { get; set; }
    public virtual ICollection<BookGenreLink> SecondaryBooks { get; set; }
}
