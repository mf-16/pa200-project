using System.ComponentModel.DataAnnotations;

namespace WebMVC.Models.Publisher
{
    public class UpdatePublisherViewModel
    {
        [StringLength(200, ErrorMessage = "Bio can't be longer than 200 characters.")]
        public string Bio { get; set; }
    }
}
