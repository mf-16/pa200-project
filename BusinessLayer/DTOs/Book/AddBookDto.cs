using System.ComponentModel.DataAnnotations;
using DataAccessLayer.Enums;
using DataAccessLayer.Model;
using Microsoft.AspNetCore.Http;

namespace BusinessLayer.DTOs.Book;

public class AddBookDto
{
    [Required]
    public string Title { get; set; }
    public int AuthorId { get; set; }
    public int PublisherId { get; set; }
    public decimal Price { get; set; }
    public string Description { get; set; }
    public string ImagePath { get; set; }
    public BookGenre Genre { get; set; }
}
