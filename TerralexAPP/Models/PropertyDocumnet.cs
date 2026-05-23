using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TerralexApp.Models;

public partial class PropertyDocumnet
{
    [Key]
    public int PropertyDocumentId { get; set; }

    public int PropertyId { get; set; }

    [Required(ErrorMessage = "Document path is required")]
    [StringLength(255, ErrorMessage = "Document path cannot exceed 255 characters")]
    public string DoucmentPath { get; set; }

    public bool IsDeleted { get; set; }

    [ForeignKey("PropertyId")]
    [InverseProperty("PropertyDocumnets")]
    public virtual Property Property { get; set; }
}