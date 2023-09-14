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
                    Name = "ĳ� �������",
                    TimeWork = "��-��: 9:30 - 23:00, ��-��: 9:30 - 22:00",
                    Location = "������ �����������, 8/1, �������"
                },
                new Restaurant
                {
                    Name = "�����-��� \"Pleasantville\"",
                    TimeWork = "��-��: 11:00 - 23:00, ��-��: 11:00 - 22:00",
                    Location = "������ �������, 13, �������"
                },
                new Restaurant
                {
                    Name = "City Restobar",
                    TimeWork = "��-��: 11:00 - 23:00, ��-��: 11:00 - 22:00",
                    Location = "������ �����������, 20, �������"
                },
                new Restaurant
                {
                    Name = "�����",
                    TimeWork = "��-��: 10:00 - 22:00, ��-��: 09:00 - 22:00",
                    Location = "������ �����������, 8/1, �������"
                },
                new Restaurant
                {
                    Name = "Barbarossa Bar",
                    TimeWork = "��-��: 12:00 - 23:00, ��: 12:00 - 02:00",
                    Location = "������ ������ �������������, 4, �������"
                }
            };
            
        }
    }
}
