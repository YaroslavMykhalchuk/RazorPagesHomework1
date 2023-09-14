using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Homework1.Pages
{
    public class Task2Model : PageModel
    {
        public char RandomLetter { get; private set; }
        public void OnGet()
        {
            Random random= new Random();
            int randomNumberLetter = random.Next(97, 122);
            RandomLetter = (char)randomNumberLetter;
        }
    }
}
