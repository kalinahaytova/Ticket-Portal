using System;
using System.Collections.Generic;
using System.Text;
using Ticket_Portal.Mediator.Abstractions;

namespace Ticket_Portal.Mediator
{
    public class ConcreteUser : User
    {
        public ConcreteUser(PortalMediator portal) : base(portal)
        {

        }
        public void Send(string message)
        {
            mediator.Send(message, this);
        }
        public void Recieve(string message)
        {
            Console.WriteLine("Your tickets have been reserved successfully! Proceed to payment.");
        }
    }
}
