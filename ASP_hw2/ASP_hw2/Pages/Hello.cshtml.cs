using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASP_hw2.Pages
{
    public class HelloModel : PageModel
    {
        public string Message { get; set; }
        public void OnGet()
        {
            Message = "Hello, student!";
        }
    }
}
