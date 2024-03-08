using System.ComponentModel.DataAnnotations;
using hospital.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MySqlX.XDevAPI.Common;
using Newtonsoft.Json;

namespace hospital.Pages;

public class IndexPageModel : PageModel
{
    private readonly ILogger<IndexPageModel> _logger;
    private readonly Data.DataContext _context;

    public IndexPageModel(ILogger<IndexPageModel> logger, Data.DataContext context)
    {
        _logger = logger;
        _context = context;
    }

    public IList<Patient> Patients { get; set; } = default!;

    public void OnGet()
    {
        Patients = _context.Patients.ToList();
    }
    [BindProperty]
    public CreatePatientRequest CreatePatientRequest { get; set; }
    public async Task<IActionResult> OnPost()
    {

        var form = Request.Form;

        return RedirectToPage("Index");
    }
}

public class CreatePatientRequest
{

    [Required(ErrorMessage = "Patient firstName is required")]
    public required string FirstName;

    [Required(ErrorMessage = "Patient awefwef is required")]
    public required string Awefwef;
}