using BusinessLayer.DTOs.Book;

namespace BusinessLayer.DTOs.Publisher;

public class ResponsePublisherDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Bio { get; set; }
    public List<ResponseBookDto> Books { get; set; }
}
