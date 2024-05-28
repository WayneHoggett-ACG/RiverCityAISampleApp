using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RiverCityAI.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public string ServerName { get; private set; }
    public string ServerPrivateIP { get; private set; }

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
        ServerName = Environment.MachineName;
        try
        {
            ServerPrivateIP = Environment.GetEnvironmentVariable("WEBSITE_PRIVATE_IP").ToString();
        }
        catch
        {
            ServerPrivateIP = "Not VNet Integrated";
        }
    }
}
