using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TerralexApp.Models;

public partial class Template
{
    [Key]
    public int TemplateId { get; set; }

    [Required(ErrorMessage = "Template name is required")]
    [StringLength(200, ErrorMessage = "Template name cannot exceed 200 characters")]
    public string TemplateName { get; set; }

    [StringLength(250, ErrorMessage = "Template content path cannot exceed 250 characters")]
    public string? TemplateContentPath { get; set; }

    public bool IsDeleted { get; set; }

    [InverseProperty("Template")]
    public virtual ICollection<TransactionDocument> TransactionDocuments { get; set; } = new List<TransactionDocument>();
}