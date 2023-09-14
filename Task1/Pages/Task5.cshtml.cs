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
                new Country { Name = "������", Capital = "���", Population = 44009214, CodeFlag = "ua" },
                new Country { Name = "�������� ����� �������", Capital = "���������, D.C.", Population = 331915073, CodeFlag = "us" },
                new Country { Name = "������", Capital = "������", Population = 38005238, CodeFlag = "ca" },
                new Country { Name = "������ �������", Capital = "������", Population = 68207116, CodeFlag = "gb" },
                new Country { Name = "�������", Capital = "�����", Population = 65273511, CodeFlag = "fr" },
                new Country { Name = "ͳ�������", Capital = "�����", Population = 83783942, CodeFlag = "de" },
                new Country { Name = "������", Capital = "������", Population = 46754778, CodeFlag = "es" },
                new Country { Name = "�����", Capital = "����", Population = 1444216107, CodeFlag = "cn" },
                new Country { Name = "����", Capital = "���-���", Population = 1393409038, CodeFlag = "in" }

            };
        }
    
    }
}
