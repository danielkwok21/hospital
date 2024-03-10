namespace hospital.Controller;
using System.ComponentModel.DataAnnotations;
using hospital.Models;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("patient")]
public class PatientController : ControllerBase
{
    private readonly ILogger<PatientController> _logger;

    public PatientController(ILogger<PatientController> logger)
    {
        _logger = logger;
    }

    [HttpPost("")]
    public IActionResult OnPost(CreatePatientRequest createPatientRequest)
    {

        try
        {

            var patient = new Patient(
                createPatientRequest.FirstName,
                createPatientRequest.LastName,
                createPatientRequest.DateOfBirth,
                createPatientRequest.Gender,
                createPatientRequest.Address,
                createPatientRequest.PhoneNumber,
                createPatientRequest.Email,
                createPatientRequest.DischargeDate,
                createPatientRequest.BedNumber,
                createPatientRequest.Ward,
                createPatientRequest.Diagnosis
            );

            return Ok(patient);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, ex.Message);
            return StatusCode(StatusCodes.Status500InternalServerError, "Something went wrong");
        }
    }
}



public class CreatePatientRequest
{
    [Required(ErrorMessage = "First Name is required.")]
    public string? FirstName { get; set; }

    [Required(ErrorMessage = "Last Name is required.")]
    public string? LastName { get; set; }

    public DateTime DateOfBirth { get; set; }

    [Required(ErrorMessage = "Gender is required.")]
    public string? Gender { get; set; }

    public string? Address { get; set; }

    public string? PhoneNumber { get; set; }

    public string? Email { get; set; }

    public DateTime AdmissionDate { get; set; }

    public DateTime DischargeDate { get; set; }

    public int BedNumber { get; set; }

    public string? Ward { get; set; }

    public string? Diagnosis { get; set; }
}
public class CreatePatientResponseError
{
    public required IEnumerable<string> Errors { get; set; }
}