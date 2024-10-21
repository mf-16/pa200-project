using System.ComponentModel.DataAnnotations;

namespace BusinessLayer.DTOs.Publisher;

public class AddPublisherDto
{
    [Required]
    public string Name { get; set; }
    public string Bio { get; set; }
}
