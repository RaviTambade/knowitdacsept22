using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace OnlineShoppingWeb.Pages;

public class AboutusModel : PageModel
{
    private const double PI=3.14;

    private readonly ILogger<AboutusModel> _logger;

    public AboutusModel(ILogger<AboutusModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
        

    }
}

//Code behind file