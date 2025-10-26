using System.Reflection;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASP_hw1.Pages
{

    public class ContactModel : PageModel
    {
        [BindProperty]
        public string UserName { get; set; } = "";
        public string UserEmail { get; set; } = "";
        public string Message { get; set; } = "";
        public string Result { get; set; } = "";

        
        public void OnGet()
        {
            
        }
        public void OnPost()
        {
                Result = $"Дякуємо, {UserName}! Ваше повідомлення надісланно";

        }
    }
    
}
