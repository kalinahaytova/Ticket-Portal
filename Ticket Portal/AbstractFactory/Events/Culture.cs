using System;
using System.Collections.Generic;
using System.Text;
using Ticket_Portal.AbstractFactory.Abstractions;
using Ticket_Portal.AbstractFactory.Events.Gigs;

namespace Ticket_Portal.AbstractFactory.Events
{
    public abstract class Culture : CategoryFactory
    {
        public override List<Event> GetEvents()
        {
            return new List<Event>()
            {
                new Comedy()
                {
                    ID = 1,
                    Gig = "FRIDAY 13",
                    StartDate = new DateTime(2021, 6, 30),
                    EndDate = new DateTime(2021, 6, 30),
                    Location = "Orpheus, Plovdiv",
                    Price = 30.00
                },
                new Theatre()
                {
                    ID = 2,
                    Gig = "Avenue Q",
                    StartDate = new DateTime(2021, 7, 15),
                    EndDate = new DateTime(2021, 7, 15),
                    Location = "Borisova Garden Park, Sofia",
                    Price = 20.00
                },
                new Ballet()
                {
                    ID = 3,
                    Gig = "SWAN LAKE",
                    StartDate = new DateTime(2021, 8, 17),
                    EndDate = new DateTime(2021, 8, 17),
                    Location = "Summer Theater, Varna",
                    Price = 45.00
                },
                new Opera()
                {
                    ID = 4,
                    Gig = "MAGIC FLUTE - PREMIERE",
                    StartDate = new DateTime(2021, 6, 22),
                    EndDate = new DateTime(2021, 6, 22),
                    Location = "Summer Theater, Varna",
                    Price = 45.00
                }
            };
        }
    }
}
