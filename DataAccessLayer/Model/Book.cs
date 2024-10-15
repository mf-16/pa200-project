using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccessLayer.Model
{
    public class Book : BaseEntity
    {
        public required string Title { get; set; }
        public int AuthorId { get; set; }
        [ForeignKey("AuthorId")]
        public required Author Author { get; set; }
        public int PublisherId { get; set; }
        [ForeignKey("PublisherId")]
        public required Publisher Publisher { get; set; }
        public decimal Price { get; set; }
        public string ImagePath { get; set; }
        public BookGenre Genre { get; set; }
    }
}
