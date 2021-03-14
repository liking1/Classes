using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Client cl = new Client("Vlad", "+380554253165");
            Event ev = new Event(cl, new DateTime(2025, 5, 8), "Prom", 21, "Marmeladka");
            ev.AddDays(2);
            ev.AddWeeks(2);
            Console.WriteLine(ev);
            Console.WriteLine("All events in next week: ");
            List<Event> events = new List<Event>();
            events.Add(new Event(new Client("Valera", "+380554343165"), new DateTime(2021, 3, 21), "Bad day", 15, "Amigo"));
            events.Add(new Event(new Client("Valera1", "+380554343365"), new DateTime(2021, 3, 28), "Good day", 11, "Shinok"));
            var eventOnNextWeek = Event.GetEventsOnNextWeek(events);
            foreach (var item in eventOnNextWeek)
            {
                Console.WriteLine(item);
            }
            int maxCount = (int)events.Max(c => c.CountPeople);
            int minCount = (int)events.Min(c => c.CountPeople);
            Console.WriteLine();
            Console.WriteLine($"Max peoples : {maxCount}");
            Console.WriteLine($"Min peoples : {minCount}");
        }
    }
}
