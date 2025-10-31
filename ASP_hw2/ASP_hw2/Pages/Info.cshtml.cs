using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASP_hw2.Pages
{
    public class InfoModel : PageModel
    {
        public void OnGet()
        {
            ViewData["message"] = "Hello, student!";
        }
    }
}
