using System;
using System.Collections.Generic;
using System.Text;
using Ticket_Portal.AbstractFactory.Abstractions;
using Ticket_Portal.State;

namespace Ticket_Portal.AbstractFactory
{
    public class CategoryManage
    {
        private readonly List<Event> _event;
        private readonly CategoryFactory _category;
        private readonly EventState state;
        
        public CategoryManage(CategoryFactory categoryFactory)
        {
            this._category = categoryFactory;
            _event = categoryFactory.GetEvents();

        }
        public void GetEventInfo()
        {
            Console.WriteLine("Your chosen category: {0}", _category.GetType().Name);
            Console.WriteLine();
            for(int i=0; i<_event.Count; i++)
            {
                Console.WriteLine(_event[i].ID + ". " + _event[i].Gig);
                if (_event[i].StartDate > new DateTime(2021, 6, 24) || _event[i].EndDate > new DateTime(2021, 6, 24))
                {

                    if (_event[i].StartDate < new DateTime(2021, 7, 24) || _event[i].EndDate < new DateTime(2021, 7, 24))
                    {
                        state.EndedEvent();
                        state.State();
                        Console.WriteLine(_event[i].StartDate);
                        Console.WriteLine("Ended: {0}", _event[i].EndDate);
                    }
                    else
                    {
                        state.UpcomingEvent();
                        state.State();
                        Console.WriteLine(_event[i].StartDate);
                        Console.WriteLine("Ends: {0}", _event[i].EndDate);
                    }
                }
                Console.WriteLine("Location: {0}", _event[i].Location);
                Console.WriteLine("Price / Ticket: {0}", _event[i].Price + "$");
            }
        }
    }
}
