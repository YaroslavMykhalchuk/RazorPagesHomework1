using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Homework1.Pages
{
    public class Task4Model : PageModel
    {
        public class Restaurant
        {
            public string Name { get; set; }
            public string TimeWork { get; set; }
            public string Location { get; set; }
        }

        public Restaurant[] restaurants { get; set; }
        public void OnGet()
        {
            restaurants = new Restaurant[]
            {
                new Restaurant
                {
                    Name = "ƒ≥м “рибел€",
                    TimeWork = "ѕт-—б: 9:30 - 23:00, Ќд-„т: 9:30 - 22:00",
                    Location = "вулиц€ ћихайл≥вська, 8/1, ∆итомир"
                },
                new Restaurant
                {
                    Name = "√риль-бар \"Pleasantville\"",
                    TimeWork = "ѕт-—б: 11:00 - 23:00, Ќд-„т: 11:00 - 22:00",
                    Location = "вулиц€  ињвська, 13, ∆итомир"
                },
                new Restaurant
                {
                    Name = "City Restobar",
                    TimeWork = "ѕт-—б: 11:00 - 23:00, Ќд-„т: 11:00 - 22:00",
                    Location = "вулиц€ ћихайл≥вська, 20, ∆итомир"
                },
                new Restaurant
                {
                    Name = "‘ам≥л≥€",
                    TimeWork = "ѕт-—б: 10:00 - 22:00, Ќд-„т: 09:00 - 22:00",
                    Location = "вулиц€ ћихайл≥вська, 8/1, ∆итомир"
                },
                new Restaurant
                {
                    Name = "Barbarossa Bar",
                    TimeWork = "ѕн-—б: 12:00 - 23:00, Ќд: 12:00 - 02:00",
                    Location = "вулиц€ Ѕориса Ћ€тошинського, 4, ∆итомир"
                }
            };
            
        }
    }
}
