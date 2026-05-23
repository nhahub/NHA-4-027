using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TerralexApp.Models;

public partial class OfficeStuff
{
    [Key]
    public int StuffId { get; set; }

    public int OfficeId { get; set; }

    [Required(ErrorMessage = "Name is required")]
    [StringLength(150, ErrorMessage = "Name cannot exceed 150 characters")]
    public string Name { get; set; }

    [Required(ErrorMessage = "Job title is required")]
    [StringLength(150, ErrorMessage = "Job title cannot exceed 150 characters")]
    public string JobTitle { get; set; }

    public bool IsDeleted { get; set; }

    [ForeignKey("OfficeId")]
    [InverseProperty("OfficeStuffs")]
    public virtual OfficeProfile Office { get; set; }

    [InverseProperty("Stuff")]
    public virtual ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();
}