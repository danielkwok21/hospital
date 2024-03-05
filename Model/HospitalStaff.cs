using System.ComponentModel.DataAnnotations.Schema;

namespace hospital.Models;

[Table("hospital_staff")]
public class HospitalStaff
{
    [Column("id")]
    public int Id { get; set; }
    [Column("email")]
    public required string Email { get; set; }
    [Column("hashed_password")]
    public required string HashedPassword { get; set; }
    [Column("hospital_id")]
    public int HospitalId { get; set; }
    [Column("created_at")]
    public DateTime CreatedAt { get; set; }
    [Column("updated_at")]
    public DateTime UpdatedAt { get; set; }

}