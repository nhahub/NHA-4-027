using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TerralexApp.Models;

public partial class City
{
    [Key]
    public int CityId { get; set; }

    [Required(ErrorMessage = "City name is required")]
    [StringLength(100, ErrorMessage = "City name cannot exceed 100 characters")]
    public string Name { get; set; }

    public bool IsDeleted { get; set; }

    [InverseProperty("City")]
    public virtual ICollection<Property> Properties { get; set; } = new List<Property>();
}