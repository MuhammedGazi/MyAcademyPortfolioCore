using System.ComponentModel.DataAnnotations;

namespace Portfolio.Web.Models
{
    public class ProfileEdirtModel
    {
        public string? UserName { get; set; }
        public string? CurrentPassword { get; set; } 
        public string? NewPassword { get; set; }
    }
}
