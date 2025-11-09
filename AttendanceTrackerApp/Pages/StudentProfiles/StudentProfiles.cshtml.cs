using Microsoft.AspNetCore.Mvc.RazorPages;

public class StudentProfile : PageModel
{
    readonly ILogger<StudentProfile> logger;

    public StudentProfile(ILogger<StudentProfile> logger)
    {
        this.logger = logger;
    }

    public void OnGet()
    {
        
    }
    
    public void OnPost()
    {
        
    }
}