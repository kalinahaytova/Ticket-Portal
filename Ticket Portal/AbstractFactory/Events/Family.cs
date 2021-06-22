using System;
using System.Collections.Generic;
using System.Text;
using Ticket_Portal.AbstractFactory.Abstractions;
using Ticket_Portal.AbstractFactory.Events.Gigs;

namespace Ticket_Portal.AbstractFactory.Events
{
    public abstract class Family : CategoryFactory
    {
        public override List<Event> GetEvents()
        {
            return new List<Event>()
            {
                new AutoFest()
                {
                    ID = 1,
                    Gig = "AUTO VARNA E-MOBILITY 2021",
                    StartDate = new DateTime(2021, 6, 18),
                    EndDate = new DateTime(2021, 6, 20),
                    Location = "DKS, Varna",
                    Price = 5.00
                },
                new AutoSalon()
                {
                    ID = 2,
                    Gig = "Auto Salon Sofia 2021",
                    StartDate = new DateTime(2021, 10, 16),
                    EndDate = new DateTime(2021, 10, 24),
                    Location = "Inter Expo Centre, Sofia",
                    Price = 22.00
                }
            };
        }
    }
}
