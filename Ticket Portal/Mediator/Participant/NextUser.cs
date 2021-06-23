using System;
using System.Collections.Generic;
using System.Text;
using Ticket_Portal.Mediator.Abstractions;
using Ticket_Portal.Mediator.Participant;

namespace Ticket_Portal.Mediator
{
    public class NextUser : User
    {
        public NextUser(PortalMediator portal) : base(portal)
        {

        }
        public void Send(string message)
        {
            mediator.Send(message, this);
        }
        public void Recieve(string message)
        {
            Console.WriteLine(message);
        }
    }
}
