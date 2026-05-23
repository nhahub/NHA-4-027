using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TerralexApp.Models;

public partial class ProppertyCategory
{
    [Key]
    public int PropertyCategoryId { get; set; }

    [Required(ErrorMessage = "Name is required")]
    [StringLength(50, ErrorMessage = "Name cannot exceed 50 characters")]
    public string Name { get; set; }

    public bool IsDeleted { get; set; }

    [InverseProperty("PropertyCategory")]
    public virtual ICollection<PropertyType> PropertyTypes { get; set; } = new List<PropertyType>();
}