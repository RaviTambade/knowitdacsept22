using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace OnlineShoppingWeb.Pages;

public class LoginModel : PageModel
{
    private const double PI=3.14;

    private readonly ILogger<LoginModel> _logger;

    public LoginModel(ILogger<LoginModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
          Console.WriteLine("Login get method is invoked...");

    }
    public void OnPost()
    {
        Console.WriteLine("Login post method is invoked...");

        var emailAddress = Request.Form["email"];
        var password = Request.Form["password"];
        if(emailAddress =="ravi.tambade@transflower.in" && password=="seed123"){
            Response.Redirect("/welcome");
        }
        // do something with emailAddress
    }

}

//Code behind file