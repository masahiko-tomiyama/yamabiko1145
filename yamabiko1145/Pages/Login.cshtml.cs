using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace yamabiko1145.Pages;

public class PrivacyModel : PageModel
{
    private readonly ILogger<PrivacyModel> _logger;

    public PrivacyModel(ILogger<PrivacyModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }

    public void OnPost(string id)
    {
        Thread.Sleep(2000);             // 機器からのレスポンスを2秒待って
        Response.Redirect("./Privacy"); // 再表示

        return;
    }
}


