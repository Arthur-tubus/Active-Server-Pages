using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASP_hw2.Pages
{
    public class ContactModel : PageModel
    {
        [BindProperty]
        public string Name { get; set; }
        public string Greeting { get; set; }
        public void OnGet()
        {
            Greeting = $"Hello, {Name}!";
        }
    }
}
