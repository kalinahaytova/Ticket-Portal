using System;
using System.Collections.Generic;
using System.Text;
using Ticket_Portal.Mediator.Abstractions;

namespace Ticket_Portal.Mediator.Participant
{
    public class FinishUser : User
    {
        public FinishUser(PortalMediator portal) : base(portal)
        {

        }
        public void Send(string message)
        {
            mediator.Send(message, this);
        }
        public void Recieve(string message)
        {
            Console.WriteLine("Tickets reserved successfully! Proceed to payment.");
        }
    }
}
