using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASP_hw1.Pages
{
    public class QuotesModel : PageModel
    {
        [BindProperty]
        public int RandomNumber { get; set; } = 0;
        public string Message { get; set; } = "";

        private static readonly string[] Quotes = {
            "Секрет успіху — це почати.",
            "Вчитися ніколи не пізно.",
            "Кожна помилка — це крок до перемоги.",
            "Сьогодні — найкращий день, щоб почати.",
            "Мрій масштабно, працюй наполегливо.",
            "Хочеш поїсти - поїш"
        };
        public void OnGet()
        { 
            RandomNumber = new Random().Next(0, 6);
            Message = Quotes[RandomNumber];
        }
       }
}
