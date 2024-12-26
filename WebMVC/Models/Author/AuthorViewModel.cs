using System.Collections.Generic;
using WebMVC.Models.Book;

namespace WebMVC.Models.Author
{
    public class AuthorViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Bio { get; set; }
        public List<BookViewModel> Books { get; set; }
    }
}
