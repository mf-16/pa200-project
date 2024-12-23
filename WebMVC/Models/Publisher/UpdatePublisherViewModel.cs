using System.ComponentModel.DataAnnotations;

namespace WebMVC.Models.Publisher
{
    public class UpdatePublisherViewModel
    {
        [Required(ErrorMessage = "Name is required.")]
        [StringLength(100, ErrorMessage = "Name can't be longer than 100 characters.")]
        public string Name { get; set; }

        [StringLength(200, ErrorMessage = "Bio can't be longer than 200 characters.")]
        public string Bio { get; set; }
    }
}
