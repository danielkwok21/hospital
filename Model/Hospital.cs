using System.ComponentModel.DataAnnotations.Schema;

namespace hospital.Models;

[Table("hospital")]
public class Hospital
{
    [Column("id")]
    public int Id { get; set; }
    [Column("name")]
    public required string address { get; set; }
    [Column("address")]
    public string? Address { get; set; }
    [Column("created_at")]
    public DateTime CreatedAt { get; set; }
    [Column("updated_at")]
    public DateTime UpdatedAt { get; set; }

}