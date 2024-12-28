using System.ComponentModel.DataAnnotations;

namespace WebMVC.Models.Author
{
    public class CreateAuthorViewModel
    {
        [Required(ErrorMessage = "Name is required.")]
        [StringLength(100, ErrorMessage = "Name can't be longer than 100 characters.")]
        public string Name { get; set; }

        [StringLength(200, ErrorMessage = "Bio can't be longer than 200 characters.")]
        public string Bio { get; set; }
    }
}
