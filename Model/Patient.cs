using System.ComponentModel.DataAnnotations.Schema;

namespace hospital.Models;

[Table("patient")]
public class Patient
{
    [Column("id")]
    public int Id { get; set; }
    [Column("first_name")]
    public required string FirstName { get; set; }
    [Column("last_name")]
    public required string LastName { get; set; }
    [Column("date_of_birth")]
    public DateTime DateOfBirth { get; set; }
    [Column("gender")]
    public required string Gender { get; set; }
    [Column("Address")]
    public string? Address { get; set; }
    [Column("phone_number")]
    public string? PhoneNumber { get; set; }
    [Column("email")]
    public string? Email { get; set; }
    [Column("admission_date")]
    public DateTime AdmissionDate { get; set; }
    [Column("discharge_date")]
    public DateTime DischargeDate { get; set; }
    [Column("bed_number")]
    public int BedNumber { get; set; }
    [Column("ward")]
    public string? Ward { get; set; }
    [Column("diagnosis")]
    public string? Diagnosis { get; set; }
    [Column("created_at")]
    public DateTime CreatedAt { get; set; }
    [Column("updated_at")]
    public DateTime UpdatedAt { get; set; }

}