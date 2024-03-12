using hospital.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

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
}
