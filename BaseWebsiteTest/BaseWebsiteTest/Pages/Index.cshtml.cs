using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BaseWebsiteTest.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
        // This should not be used in production and should be removed for the assessment
        var randomSleepTime = new Random();
        Thread.Sleep(randomSleepTime.Next(5000, 7000));
    }
}