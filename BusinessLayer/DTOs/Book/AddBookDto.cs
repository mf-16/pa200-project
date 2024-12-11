using System.ComponentModel.DataAnnotations;
using DataAccessLayer.Model;
using Microsoft.AspNetCore.Http;

namespace BusinessLayer.DTOs.Book;

public class AddBookDto
{
    [Required]
    public string Title { get; set; }
    [Required]
    public int AuthorId { get; set; }
    [Required]
    public int PublisherId { get; set; }
    [Required]
    public decimal Price { get; set; }
    [Required]
    public string Description { get; set; }
    [Required]
    public int PrimaryGenreId { get; set; }
}
