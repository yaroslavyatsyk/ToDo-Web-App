using Microsoft.AspNetCore.Identity;

namespace ToDo_Web_App.Models
{
    public class ApplicationUser : IdentityUser
    {
        public List<Assignment> Assignments { get; set; }
    }
}
