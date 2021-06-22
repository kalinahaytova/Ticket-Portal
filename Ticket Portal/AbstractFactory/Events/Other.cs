using System;
using System.Collections.Generic;
using System.Text;
using Ticket_Portal.AbstractFactory.Abstractions;
using Ticket_Portal.AbstractFactory.Events.Gigs;

namespace Ticket_Portal.AbstractFactory.Events
{
    public class Other : CategoryFactory
    {
        public override List<Event> GetEvents()
        {
            return new List<Event>()
            {
                new Museum()
                {
                    ID = 1,
                    Gig = "Illusion Museum visit",
                    StartDate = new DateTime(2021, 2, 17),
                    EndDate = new DateTime(2021, 12, 31),
                    Location = "Museum of Illusion, Sofia",
                    Price = 21.00
                },
                new Movie()
                {
                    ID = 2,
                    Gig = "LORD OF THE RINGS: RETURN OF THE KING -  CONCERT",
                    StartDate = new DateTime(2021, 8, 1),
                    EndDate = new DateTime(2021, 8, 2),
                    Location = "Ancient Theatre, Plovdiv",
                    Price = 90.00
                }
            };
        }
    }
}
