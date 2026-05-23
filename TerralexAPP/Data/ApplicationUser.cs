using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace TerralexAPP.Data
{
    public class ApplicationUser : IdentityUser<int>
    {
        [MaxLength(20)]
        public string? City { get; set; }
    }
}
