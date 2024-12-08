namespace DataAccessLayer.Model;

public class BookGenreLink
{
    public int Id { get; set; }
    public int BookId { get; set; }
    public virtual Book Book { get; set; }

    public int GenreId { get; set; }
    public virtual BookGenre Genre { get; set; }
}
