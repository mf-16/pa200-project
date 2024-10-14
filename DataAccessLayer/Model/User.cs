using Microsoft.AspNetCore.Identity;

namespace DataAccessLayer.Model;

public class User : IdentityUser<int>
{
    public string Name { get; set; }
}
