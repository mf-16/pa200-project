using WebMVC.Models.User;

namespace WebMVC.Models.Review;

public class ReviewViewModel
{
    public int Id { get; set; }
    public int Stars { get; set; }
    public string Comment { get; set; }

    public UserViewModel User { get; set; }
}
