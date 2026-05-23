using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TerralexApp.Models;

public partial class ClientDocument
{
    [Key]
    public int ClientDocumentId { get; set; }

    public int ClientId { get; set; }

    [Required(ErrorMessage = "Document name is required")]
    [StringLength(500, ErrorMessage = "Document name cannot exceed 500 characters")]
    public string DocumentName { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime CreateDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? RenewalDate { get; set; }

    public bool IsDeleted { get; set; }

    [ForeignKey("ClientId")]
    [InverseProperty("ClientDocuments")]
    public virtual Client Client { get; set; }
}