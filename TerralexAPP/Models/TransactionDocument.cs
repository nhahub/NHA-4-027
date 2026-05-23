using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TerralexApp.Models;

public partial class TransactionDocument
{
    [Key]
    public int TransactionDocument_Id { get; set; }

    public int TransactionId { get; set; }

    [Required(ErrorMessage = "Name is required")]
    [StringLength(150, ErrorMessage = "Name cannot exceed 150 characters")]
    public string DocumentType { get; set; }

    public int TemplateId { get; set; }

    [Required(ErrorMessage = "Document name is required")]
    [StringLength(150, ErrorMessage = "Document name cannot exceed 150 characters")]
    public string DocumentName { get; set; }

    [Required(ErrorMessage = "File path is required")]
    [StringLength(250, ErrorMessage = "File path cannot exceed 250 characters")]
    public string FilePath { get; set; }

    [StringLength(500, ErrorMessage = "Description cannot exceed 500 characters")]
    public string Description { get; set; }

    [StringLength(500, ErrorMessage = "Notes cannot exceed 500 characters")]
    public string Notes { get; set; }

    public bool IsDeleted { get; set; }

    [ForeignKey("TemplateId")]
    [InverseProperty("TransactionDocuments")]
    public virtual Template Template { get; set; }

    [ForeignKey("TransactionId")]
    [InverseProperty("TransactionDocuments")]
    public virtual Transaction Transaction { get; set; }
}