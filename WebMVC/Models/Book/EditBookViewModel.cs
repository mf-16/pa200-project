using System.ComponentModel.DataAnnotations;

namespace WebMVC.Models.Book;

public class EditBookViewModel
{
    [Required]
    public int Id { get; set; }

    [Required(ErrorMessage = "Title is required.")]
    public string Title { get; set; }

    [Required(ErrorMessage = "Author is required.")]
    public int AuthorId { get; set; }

    [Required(ErrorMessage = "Publisher is required.")]
    public int PublisherId { get; set; }

    [Required(ErrorMessage = "Price is required.")]
    public decimal Price { get; set; }

    [Required(ErrorMessage = "Description is required.")]
    public string Description { get; set; }

    [Required(ErrorMessage = "Genre is required.")]
    public int PrimaryGenreId { get; set; }
}
