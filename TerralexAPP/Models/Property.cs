using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TerralexApp.Models;

public partial class Property
{
    [Key]
    public int PropertyId { get; set; }

    [Required(ErrorMessage = "Address is required")]
    [StringLength(500, ErrorMessage = "Address cannot exceed 500 characters")]
    public string Address { get; set; }

    public int CityId { get; set; }

    [Required(ErrorMessage = "District is required")]
    [StringLength(50, ErrorMessage = "District cannot exceed 50 characters")]
    public string District { get; set; }

    public int PropertyTypeId { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal Area { get; set; }

    public int? Floors { get; set; }

    public int? Rooms { get; set; }

    public int? Bathrooms { get; set; }

    [StringLength(500, ErrorMessage = "Description cannot exceed 500 characters")]
    public string Description { get; set; }

    [StringLength(10, ErrorMessage = "Documents cannot exceed 10 characters")]
    public string Documents { get; set; }

    public bool IsDeleted { get; set; }

    [ForeignKey("CityId")]
    [InverseProperty("Properties")]
    public virtual City City { get; set; }

    [InverseProperty("Property")]
    public virtual ICollection<PropertyDocumnet> PropertyDocumnets { get; set; } = new List<PropertyDocumnet>();

    [InverseProperty("Property")]
    public virtual ICollection<PropertyImage> PropertyImages { get; set; } = new List<PropertyImage>();

    [ForeignKey("PropertyTypeId")]
    [InverseProperty("Properties")]
    public virtual PropertyType PropertyType { get; set; }

    [InverseProperty("Property")]
    public virtual ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();
}