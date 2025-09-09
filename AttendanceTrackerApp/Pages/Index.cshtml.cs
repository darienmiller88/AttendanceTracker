using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AttendanceTrackerApp.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> logger;
    public string Message { get; set; } = "";

    public IndexModel(ILogger<IndexModel> logger)
    {
        this.logger = logger;
    }

    public void OnGet()
    {
        Message = "Test message";
    }
}