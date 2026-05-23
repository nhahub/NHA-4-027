using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TerralexApp.Models;

public partial class ServerType
{
    [Key]
    public int ServiceTypeId { get; set; }

    [Required(ErrorMessage = "Name is required")]
    [StringLength(150, ErrorMessage = "Name cannot exceed 150 characters")]
    public string Name { get; set; }

    public bool IsDeleted { get; set; }

    [InverseProperty("ServiceType")]
    public virtual ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();
}