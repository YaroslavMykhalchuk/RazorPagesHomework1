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
                Name = "ĳ� �������",
                TimeWork = "��-��: 9:30 - 23:00, ��-��: 9:30 - 22:00",
                Location = "������ �����������, 8/1, �������"
            };
        }
    }
}
