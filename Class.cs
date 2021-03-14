using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Event
    {
        private String name;
        private uint countPeople;
        private String event_Place;
        private DateTime time_Event = new DateTime();
        private readonly uint ID;
        private static uint counter;
        static Event()
        {
            counter = 0;
        }
        internal Client client = new Client();
        public string Name
        {
            get => name;
            set
            {
                if (!String.IsNullOrWhiteSpace(value))
                {
                    this.name = value;
                }
            }
        }
        public uint CountPeople
        {
            get => countPeople;
            set
            {
                this.countPeople = value;
            }
        }

        public string EventPlace
        {
            get => event_Place;
            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    this.event_Place = value;
                }

            }
        }

        public DateTime TimeEvent
        {
            get => time_Event;
            set
            {
                this.time_Event = value;
            }
        }
        public Client Client
        {
            get => client;
            set
            {
                if (value != null)
                {
                    this.client = value;
                    return;
                }
            }
        }

        public Event(Client client, DateTime time_Event, string name = "NoName", uint count_people = 0, string event_Place = "NoPlace")
        {  
            this.client = client;
            this.Name = name;
            this.TimeEvent = time_Event;
            this.CountPeople = count_people;
            this.EventPlace = event_Place;
            this.ID = ++counter;
        }

        public override string ToString()
        {
            return $"-------Event {ID}-------\n" +
                $"Client : {client}\n " +
                $"Name of event : {name}\n " +
                $"Event Time : {time_Event.Date}\n " +
                $"Count People : {countPeople}\n " +
                $"Event Place : {event_Place}";
        }

        public void AddDays(uint days)
        {
            if (days <= 0)
            {
                Console.WriteLine("Nothing to do");
                return;
            }
            this.time_Event = time_Event.AddDays(days);
        }
        public void AddWeeks(uint weeks)
        {
            if (weeks <= 0)
            {
                Console.WriteLine("Nothing to do");
                return;
            }
            weeks *= 7;
            this.time_Event = time_Event.AddDays(weeks);
        }
        public static List<Event> GetEventsOnNextWeek(List<Event> events)
        {
            List<Event> result = new List<Event>();
            foreach (var item in events)
            {
                if (DateTime.Now.AddDays(6) <= item.TimeEvent && item.TimeEvent <= DateTime.Now.AddDays(14))
                {
                    result.Add(item);
                }
            }
            return result;
        }

    }
}
