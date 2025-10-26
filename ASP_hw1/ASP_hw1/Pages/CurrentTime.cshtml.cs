using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASP_hw1.Pages
{
    public class CurrentTimeModel : PageModel
    {
        [BindProperty]
        public string CurrentTime { get; set; }
        public void OnGet()
        {
            CurrentTime = DateTime.Now.ToString();
        }
    }
}
 