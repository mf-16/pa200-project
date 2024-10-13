using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccessLayer.Model;

public class Review : BaseEntity
{
    public int UserId { get; set; }

    [ForeignKey("UserId")]
    public virtual User User { get; set; }
    public int Stars { get; set; }
    public string Comment { get; set; }

    public int BookId { get; set; }

    [ForeignKey("BookId")]
    public virtual Book Book { get; set; }
}
