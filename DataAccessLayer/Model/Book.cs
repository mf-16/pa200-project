using System.ComponentModel.DataAnnotations.Schema;
using DataAccessLayer;

namespace DataAccessLayer.Model
{
    public class Book : BaseEntity
    {
        public string Title { get; set; }
        public int AuthorId { get; set; }

        [ForeignKey("AuthorId")]
        public virtual Author Author { get; set; }
        public int PublisherId { get; set; }

        [ForeignKey("PublisherId")]
        public virtual Publisher Publisher { get; set; }
        public decimal Price { get; set; }
        public string ImagePath { get; set; }
        public string Description { get; set; }
        public int PrimaryGenreId { get; set; }

        [ForeignKey("PrimaryGenreId")]
        public virtual BookGenre PrimaryGenre { get; set; }

        public virtual ICollection<BookGenreLink> SecondaryGenres { get; set; }

        public int? LastEditorId { get; set; }

        [ForeignKey("LastEditorId")]
        public virtual User LastEditor { get; set; }

        public int EditCount { get; set; }
    }
}
