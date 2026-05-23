using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TerralexApp.Models;

public partial class OfficeProfile
{
    [Key]
    public int OfficeId { get; set; }

    [Required(ErrorMessage = "Address is required")]
    [StringLength(500, ErrorMessage = "Address cannot exceed 500 characters")]
    public string Address { get; set; }

    [Required(ErrorMessage = "Responsible person is required")]
    [StringLength(50, ErrorMessage = "Responsible person cannot exceed 50 characters")]
    public string ResponsabltyPerson { get; set; }

    [Required(ErrorMessage = "Phone is required")]
    [StringLength(100, ErrorMessage = "Phone cannot exceed 100 characters")]
    [Unicode(false)]
    public string Phone { get; set; }

    [Required(ErrorMessage = "Mobile is required")]
    [StringLength(150, ErrorMessage = "Mobile cannot exceed 150 characters")]
    [Unicode(false)]
    public string Moblie { get; set; }

    [Required(ErrorMessage = "Email is required")]
    [StringLength(250, ErrorMessage = "Email cannot exceed 250 characters")]
    [Unicode(false)]
    public string Email { get; set; }

    [StringLength(150, ErrorMessage = "Website cannot exceed 150 characters")]
    public string Website { get; set; }

    [StringLength(250, ErrorMessage = "Logo path cannot exceed 250 characters")]
    public string LogoPath { get; set; }

    public int? WorkStart { get; set; }

    public int? WorkEnd { get; set; }

    public bool IsDeleted { get; set; }

    [InverseProperty("Office")]
    public virtual ICollection<OfficeStuff> OfficeStuffs { get; set; } = new List<OfficeStuff>();
}