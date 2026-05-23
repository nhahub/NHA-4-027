using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TerralexApp.Models;

public partial class TransactionFee
{
    [Key]
    public int TransactionFeeId { get; set; }

    public int TransactionId { get; set; }

    [Required(ErrorMessage = "Item name is required")]
    [StringLength(150, ErrorMessage = "Item name cannot exceed 150 characters")]
    public string ItemName { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal Fees { get; set; }

    public bool IsDeleted { get; set; }

    [ForeignKey("TransactionId")]
    [InverseProperty("TransactionFees")]
    public virtual Transaction Transaction { get; set; }
}