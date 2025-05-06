using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using tpRazorPages.Models;
using System;

namespace tpRazorPages.Pages.TP12
{
    public class AddEventModel : PageModel
    {
        [BindProperty]
        public Event Event { get; set; }

        public static Action<Event> CreateEvent;

        public void OnGet() { }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
                return Page();

            CreateEvent?.Invoke(Event);

            return Page();
        }

        static AddEventModel()
        {
            CreateEvent += LoginEventOnConsole;
        }

        private static void LoginEventOnConsole(Event evt)
        {
            Console.WriteLine($"[EVENTO CRIADO] {evt.Title} em {evt.Location} na data {evt.Date.ToShortDateString()}");
        }
    }
}
