using System;
using System.Collections.Generic;
using System.Text;
using Ticket_Portal.AbstractFactory.Abstractions;
using Ticket_Portal.AbstractFactory.Events.Gigs;

namespace Ticket_Portal.AbstractFactory.Events
{
    public class Concert : CategoryFactory
    {
      public override List<Event> GetEvents()
        {
            return new List<Event>()
            {
                new Fest()
                {
                    ID = 1,
                    Gig = "SOFIA LIVE FESTIVAL",
                    StartDate = new DateTime(2021, 6, 18),
                    EndDate = new DateTime(2021, 6, 20),
                    Location = "Sofia Live Club",
                    Price = 20.00
                },
                new Classic()
                {
                    ID = 2,
                    Gig = "CLASSICAL CONCERT - JULIAN RACHLIN AND FRIENDS",
                    StartDate = new DateTime(2021, 7, 6),
                    EndDate = new DateTime(2021, 7, 6),
                    Location = "NHK, Burgas",
                    Price = 40.00
                },
                new Rock()
                {
                    ID = 3,
                    Gig = "VARNA ROCK 2021",
                    StartDate = new DateTime(2021, 8, 13),
                    EndDate = new DateTime(2021, 8, 15),
                    Location = "Asparuhovo Beach, Varna",
                    Price = 120.00
                }
            };
        }
    }
}
