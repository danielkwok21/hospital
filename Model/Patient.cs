using System.ComponentModel.DataAnnotations.Schema;

namespace hospital.Models;

[Table("patient")]
public class Patient
{
    [Column("id")]
    public int Id { get; set; }
    [Column("created_at")]
    public DateTime CreatedAt { get; set; }
    [Column("updated_at")]
    public DateTime UpdatedAt { get; set; }

}