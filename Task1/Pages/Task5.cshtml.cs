using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Homework1.Pages
{
    public class Task5Model : PageModel
    {
        public class Country
        {
            public string? Name { get; set; }
            public string? Capital { get; set; }
            public long Population { get; set; }
            public string? CodeFlag { get; set; }
        }
        public Country[]? countries { get; set; }
        public void OnGet()
        {
            countries = new Country[]
            {
                new Country { Name = "Україна", Capital = "Київ", Population = 44009214, CodeFlag = "ua" },
                new Country { Name = "Сполучені Штати Америки", Capital = "Вашингтон, D.C.", Population = 331915073, CodeFlag = "us" },
                new Country { Name = "Канада", Capital = "Оттава", Population = 38005238, CodeFlag = "ca" },
                new Country { Name = "Велика Британія", Capital = "Лондон", Population = 68207116, CodeFlag = "gb" },
                new Country { Name = "Франція", Capital = "Париж", Population = 65273511, CodeFlag = "fr" },
                new Country { Name = "Німеччина", Capital = "Берлін", Population = 83783942, CodeFlag = "de" },
                new Country { Name = "Іспанія", Capital = "Мадрид", Population = 46754778, CodeFlag = "es" },
                new Country { Name = "Китай", Capital = "Пекін", Population = 1444216107, CodeFlag = "cn" },
                new Country { Name = "Індія", Capital = "Нью-Делі", Population = 1393409038, CodeFlag = "in" }

            };
        }
    
    }
}
