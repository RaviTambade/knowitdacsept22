using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace OnlineShoppingWeb.Pages;

public class ContactModel : PageModel
{
    private const double PI=3.14;

    private readonly ILogger<ContactModel> _logger;

    public ContactModel(ILogger<ContactModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
        

    }
}

//Code behind file