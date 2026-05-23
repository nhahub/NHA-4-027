using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TerralexApp.Models;

public partial class Appointment
{
    [Key]
    public int AppointmentId { get; set; }

    public int ClientId { get; set; }

    public int StuffId { get; set; }

    [Required(ErrorMessage = "Title is required")]
    [StringLength(100, ErrorMessage = "Title cannot exceed 100 characters")]
    public string Title { get; set; }

    [StringLength(50, ErrorMessage = "Appointment type cannot exceed 50 characters")]
    public string AppointmentType { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime AppointmentDate { get; set; }

    [Required(ErrorMessage = "Location is required")]
    [StringLength(200, ErrorMessage = "Location cannot exceed 200 characters")]
    public string Location { get; set; }

    [StringLength(500)]
    public string? Description { get; set; }

    [Required(ErrorMessage = "Summary is required")]
    [StringLength(500, ErrorMessage = "Summary cannot exceed 500 characters")]
    public string Summary { get; set; }

    public bool IsDeleted { get; set; }

    [ForeignKey("ClientId")]
    [InverseProperty("Appointments")]
    public virtual Client Client { get; set; }
}