using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AttendanceTrackerApp.Pages;

public class LoginModel : PageModel
{
    readonly private ILogger<LoginModel> logger;
    public string Message { get; set; } = "";

    public LoginModel(ILogger<LoginModel> logger)
    {
        this.logger = logger;
    }

    public void OnGet()
    {
        Message = "login";
    }
    
    public void OnPost()
    {
        
    }
}