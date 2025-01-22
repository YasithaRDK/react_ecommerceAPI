using Microsoft.AspNetCore.Identity;

namespace ecommerceAPI.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
    }
}
