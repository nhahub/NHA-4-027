using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TerralexApp.Models;

public partial class Client
{
    [Key]
    public int ClientId { get; set; }

    [Required(ErrorMessage = "First name is required")]
    [StringLength(100)]
    public string FirstName { get; set; }

    [Required(ErrorMessage = "Last name is required")]
    [StringLength(100, ErrorMessage = "Last name cannot exceed 100 characters")]
    public string LastName { get; set; }

    [Required(ErrorMessage = "National ID is required")]
    [StringLength(14, ErrorMessage = "National ID cannot exceed 14 characters")]
    [Unicode(false)]
    public string NationalId { get; set; }

    [Required(ErrorMessage = "Mobile number is required")]
    [StringLength(15, ErrorMessage = "Mobile number cannot exceed 15 characters")]
    [Unicode(false)]
    public string Mobile { get; set; }

    [Required(ErrorMessage = "Email is required")]
    [StringLength(255, ErrorMessage = "Email cannot exceed 255 characters")]
    public string Email { get; set; }

    [StringLength(500, ErrorMessage = "Address cannot exceed 500 characters")]
    public string? Address { get; set; }

    [StringLength(50, ErrorMessage = "Client type cannot exceed 50 characters")]
    public string? ClientType { get; set; }

    [StringLength(250)]
    public string? IDImageFrontPath { get; set; }

    [StringLength(250)]
    public string? IDImageBackPath { get; set; }

    public bool IsDeleted { get; set; }

    [InverseProperty("Client")]
    public virtual ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();

    [InverseProperty("Client")]
    public virtual ICollection<ClientDocument> ClientDocuments { get; set; } = new List<ClientDocument>();

    [InverseProperty("Client")]
    public virtual ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();
}