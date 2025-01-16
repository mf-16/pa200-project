namespace WebMVC.Models.Book;

public class CreateBookCompositeViewModel
{
    public BookDropDownListItems Items { get; set; }
    public CreateBookViewModel Book { get; set; }
    public IFormFile? Image { get; set; }
}
