using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TerralexApp.Models;

public partial class PropertyType
{
    [Key]
    public int PropertyTypeId { get; set; }

    public int PropertyCategoryId { get; set; }

    [Required(ErrorMessage = "Name is required")]
    [StringLength(50, ErrorMessage = "Name cannot exceed 50 characters")]
    public string Name { get; set; }

    public bool IsDeleted { get; set; }

    [InverseProperty("PropertyType")]
    public virtual ICollection<Property> Properties { get; set; } = new List<Property>();

    [ForeignKey("PropertyCategoryId")]
    [InverseProperty("PropertyTypes")]
    public virtual ProppertyCategory PropertyCategory { get; set; }
}