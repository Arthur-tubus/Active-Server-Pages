using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASP_hw1.Pages
{
    public class TemperatureConverterModel : PageModel
    {
        [BindProperty]
        public int Celsius { get; set; } = 0;
        public int TemperatureConverter { get; set; } 
        public string Message { get; set; } = "";
        
        public void OnPost()
        {
            TemperatureConverter = Celsius * 9 / 5 + 32;
            Message = $"Температура: {TemperatureConverter}";
        }
    }
}
