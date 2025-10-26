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
            "������ ����� � �� ������.",
            "������� ����� �� ����.",
            "����� ������� � �� ���� �� ��������.",
            "������� � ��������� ����, ��� ������.",
            "��� ���������, ������ �����������.",
            "����� ����� - ���"
        };
        public void OnGet()
        { 
            RandomNumber = new Random().Next(0, 6);
            Message = Quotes[RandomNumber];
        }
       }
}
