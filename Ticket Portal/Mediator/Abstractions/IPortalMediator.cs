using System;
using System.Collections.Generic;
using System.Text;

namespace Ticket_Portal.Mediator.Abstractions
{
    public abstract class IPortalMediator
    {
        public abstract void Send(string message, User user);
    }
}
