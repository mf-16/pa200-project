using WebMVC.Models.Author;
using WebMVC.Models.Publisher;

namespace WebMVC.Models.Book;

public class EditBookCompositeViewModel
{
    public BookDropDownListItems Items { get; set; }
    public EditBookViewModel Book { get; set; }
}
