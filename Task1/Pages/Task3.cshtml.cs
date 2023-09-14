using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Homework1.Pages
{
    public class Task3Model : PageModel
    {
        public class Restaurant
        {
            public string Name { get; set; }
            public string TimeWork { get; set; }
            public string Location { get; set; }
        }

        public Restaurant restaurant { get; set; }
        public void OnGet()
        {
            restaurant = new Restaurant
            {
                Name = "Дім Трибеля",
                TimeWork = "Пт-Сб: 9:30 - 23:00, Нд-Чт: 9:30 - 22:00",
                Location = "вулиця Михайлівська, 8/1, Житомир"
            };
        }
    }
}
