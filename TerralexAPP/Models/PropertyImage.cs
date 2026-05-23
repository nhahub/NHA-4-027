using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TerralexApp.Models;

public partial class PropertyImage
{
    [Key]
    public int PropertyImageId { get; set; }

    public int PropertyId { get; set; }

    [Required(ErrorMessage = "Image path is required")]
    [StringLength(255, ErrorMessage = "Image path cannot exceed 255 characters")]
    public string ImagePath { get; set; }

    public bool IsDeleted { get; set; }

    [ForeignKey("PropertyId")]
    [InverseProperty("PropertyImages")]
    public virtual Property Property { get; set; }
}