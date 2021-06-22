using System;
using System.Collections.Generic;
using System.Text;

namespace Ticket_Portal.AbstractFactory.Abstractions
{
    public abstract class Event
    {
        public int ID { get; set; }
        public string Gig { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Location { get; set; }
        public double Price { get; set; }
    }
}
