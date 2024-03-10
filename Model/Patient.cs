using System.ComponentModel.DataAnnotations.Schema;

namespace hospital.Models;

[Table("patient")]
public class Patient
{
    public Patient(string? firstName, string? lastName, DateTime dateOfBirth, string? gender, string? address, string? phoneNumber, string? email, DateTime dischargeDate, int bedNumber, string? ward, string? diagnosis)
    {
        if (firstName == null)
        {
            throw new ArgumentNullException($"{nameof(firstName)} cannot be null");
        }

        if (lastName == null)
        {
            throw new ArgumentNullException($"{nameof(lastName)} cannot be null");
        }

        if (gender == null)
        {
            throw new ArgumentNullException($"{nameof(gender)} cannot be null");
        }

        PatientID = Guid.NewGuid();
        FirstName = firstName;
        LastName = lastName;
        DateOfBirth = dateOfBirth;
        Gender = gender;
        Address = address;
        PhoneNumber = phoneNumber;
        Email = email;
        DischargeDate = dischargeDate;
        BedNumber = bedNumber;
        Ward = ward;
        Diagnosis = diagnosis;
    }

    [Column("patient_id")]
    public Guid PatientID { get; set; }
    [Column("first_name")]
    public string FirstName { get; set; }
    [Column("last_name")]
    public string LastName { get; set; }
    [Column("date_of_birth")]
    public DateTime DateOfBirth { get; set; }
    [Column("gender")]
    public string Gender { get; set; }
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