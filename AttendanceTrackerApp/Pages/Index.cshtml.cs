using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AttendanceTrackerApp.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        this.logger = logger;

        Console.WriteLine(logger);
    }

    public void OnGet()
    {
        
    }
}