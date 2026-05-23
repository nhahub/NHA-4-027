using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TerralexApp.Models;

[Table("TransactionStatus")]
public partial class TransactionStatus
{
    [Key]
    public int TransactionStatusId { get; set; }

    [Required(ErrorMessage = "Name is required")]
    [StringLength(100, ErrorMessage = "Name cannot exceed 100 characters")]
    public string Name { get; set; }

    public bool IsDeleted { get; set; }

    [InverseProperty("TransactionStatus")]
    public virtual ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();
}