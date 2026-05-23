using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TerralexApp.Models;

public partial class TransactionsStage
{
    [Key]
    public int TransactionsStageId { get; set; }

    public int TransactionId { get; set; }

    [Required(ErrorMessage = "Stage name is required")]
    [StringLength(50, ErrorMessage = "Stage name cannot exceed 50 characters")]
    public string StageName { get; set; }

    public bool? StageStatus { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime StartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ExpectedEndDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime CompletedDate { get; set; }

    [StringLength(500, ErrorMessage = "Notes cannot exceed 500 characters")]
    public string Notes { get; set; }

    public bool IsDeleted { get; set; }

    [ForeignKey("TransactionId")]
    [InverseProperty("TransactionsStages")]
    public virtual Transaction Transaction { get; set; }
}