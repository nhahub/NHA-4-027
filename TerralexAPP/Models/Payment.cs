using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TerralexApp.Models;

[Index("TransactionId", Name = "IX_Payments", IsUnique = true)]
public partial class Payment
{
    [Key]
    public int PaymentId { get; set; }

    public int TransactionId { get; set; }

    [Required(ErrorMessage = "Payment type is required")]
    [StringLength(50, ErrorMessage = "Payment type cannot exceed 50 characters")]
    public string PaymentType { get; set; }

    [Column(TypeName = "decimal(7, 2)")]
    public decimal AmountService { get; set; }

    [Column(TypeName = "decimal(7, 2)")]
    public decimal? TaxValue { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal TotalAmount { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime PaymentDate { get; set; }

    [Required(ErrorMessage = "Receipt number is required")]
    [StringLength(50, ErrorMessage = "Receipt number cannot exceed 50 characters")]
    public string ReceiptNumber { get; set; }

    [StringLength(500, ErrorMessage = "Notes cannot exceed 500 characters")]
    public string Notes { get; set; }

    public bool IsDeleted { get; set; }

    [ForeignKey("TransactionId")]
    [InverseProperty("Payment")]
    public virtual Transaction Transaction { get; set; }
}