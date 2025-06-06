﻿namespace BusinessLayer.DTOs.Book;

public class UpdateBookDto
{
    public int AuthorId { get; set; }
    public int PublisherId { get; set; }
    public string Title { get; set; }
    public decimal Price { get; set; }
    public string Description { get; set; }
    public int GenreId { get; set; }
}
