using System;
using System.Collections.Generic;
using System.Text;
using Ticket_Portal.AbstractFactory.Abstractions;
using Ticket_Portal.AbstractFactory.Events.Gigs;

namespace Ticket_Portal.AbstractFactory.Events
{
    public abstract class Sport : CategoryFactory
    {
        public override List<Event> GetEvents()
        {
            return new List<Event>()
            {
                  new Box()
                  {
                        ID = 1,
                        Gig = "ONE WINNER ONE BELT",
                        StartDate = new DateTime(2021, 6, 19),
                        EndDate = new DateTime(2021, 6, 19),
                        Location = "Hotel Casino, Varna",
                        Price = 25.00
                  }
            };
        }
    }
}
