using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASP_hw1.Pages
{
    public class RandomNumberModel : PageModel
    {
        [BindProperty]
        public int RandomNumber { get; set; } 
        public void OnGet()
        {
            RandomNumber = new Random().Next(1,101);
        }
    }
}
